import configparser
import sys, os, stat
from pathlib import Path

class SettingsManager:
    DEFAULTS = {
        "General": {
            "prompt_on_start": "False",
            "open_image_start_dir": str(Path.home() / "Pictures" / "Screenshots")
        }
    }

    def __init__(self, app_name="ImV"):
        self.app_name = app_name
        self.config = configparser.ConfigParser()
        self.config_dir = self._get_config_dir(app_name)
        self.config_dir.mkdir(parents=True, exist_ok=True)
        self.config_file = self.config_dir / "settings.ini"
        self._last_mtime = None
        self._read_config(True)
    # end init

    def _get_config_dir(self, app_name):
        # return the best cross-platform directory for app settings.
        # - windows: %localappdata%\appname
        # - macos:   ~/library/application support/appname
        # - linux:   ~/.local/share/appname

        if sys.platform.startswith("win"):
             # Use USERPROFILE to get real user folder
            base = Path(Path.home() / "AppData" / "Local").expanduser()
        elif sys.platform == "darwin":  # macOS
            base = (Path.home() / "Library" / "Application Support").expanduser()
        else:  # Linux and other Unix
            base = Path(Path.home() / ".local" / "share").expanduser()
        # end if

        config_dir = Path(base / app_name).expanduser().resolve()

        return config_dir
    # end func

    def _read_config(self, force=False):
        if self.config_file.exists():
            file_mtime = self.config_file.stat().st_mtime

            if force or self._last_mtime != file_mtime:
                try:
                    self.config.read(self.config_file, encoding="utf-8")
                    self._last_mtime = file_mtime
                except:
                    # the file could not be read for some reason, save the defaults
                    self._set_defaults()
                    self.save_settings()
                # end try
            # end if
        else:
            self._set_defaults()
            self.save_settings()
        # end if
    # end func

    def _set_defaults(self):
        for section, options in self.DEFAULTS.items():
            self.config[section] = dict(options)
        # end for
    # end func

    def get(self, section, option, fallback=None):
        self._read_config()
        
        return self.config.get(section, option, fallback=fallback)
    # end func

    def get_bool(self, section, option, fallback=False):
        self._read_config()
        try:
            return self.config.getboolean(section, option)
        except (configparser.NoSectionError, configparser.NoOptionError, ValueError):
            return fallback
        # end try
    # end func

    def set(self, section, option, value):
        if section not in self.config:
            self.config[section] = {}
        # end if

        self.config[section][option] = str(value)
        self.save_settings()
    # end func

    def save_settings(self):
        try:
            orig_mode = None

            if self.config_file.exists():
                # save original permissions
                orig_mode = self.config_file.stat().st_mode
    
                # make file writable for the user if it isn’t
                if not os.access(self.config_file, os.W_OK):
                    self.config_file.chmod(stat.S_IWUSR | stat.S_IRUSR)
                # end if
            # end if
    
            # write the settings
            with open(self.config_file, "w", encoding="utf-8") as outfile:
                self.config.write(outfile)
            # end with
    
            # restore original permissions if we modified them
            if orig_mode is not None:
                self.config_file.chmod(orig_mode)
            # end if
        except PermissionError as ex:
            print(f"Permission denied: cannot save settings to {self.config_file}")    
        except Exception as ex:
            print(f"Failed to save settings: {ex}")
        # end try
    # end func
# end class