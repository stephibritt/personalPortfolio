import winreg

class RegistryManager:
    AUTOLOGON_VALUES = [
        "AutoAdminLogon",
        "DefaultUsername",
        "DefaultPassword",
        "DefaultDomainName"
    ]

    KEY_PATH = r"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon"

    def __init__(self):
        pass
    # end init

    def _open_key(self, access=winreg.KEY_READ):
        return winreg.OpenKey(winreg.HKEY_LOCAL_MACHINE, self.KEY_PATH, 0, access)
    # end func

    def get_autologon_settings(self):
        settings = {}
        with self._open_key() as key:
            for name in ["AutoAdminLogon", "DefaultUsername", "DefaultDomainName"]:
                try:
                    settings[name], _ = winreg.QueryValueEx(key, name)
                except FileNotFoundError:
                    settings[name] = None
                # end try
            # end for
        # end with

        return settings
    # end func

    def enable_autologon(self, username, password, domain=None):
        with self._open_key(winreg.KEY_SET_VALUE) as key:
            winreg.SetValueEx(key, "AutoAdminLogon", 0, winreg.REG_SZ, "1")
            winreg.SetValueEx(key, "DefaultUsername", 0, winreg.REG_SZ, username)
            winreg.SetValueEx(key, "DefaultPassword", 0, winreg.REG_SZ, password)
            if domain:
                winreg.SetValueEx(key, "DefaultDomainName", 0, winreg.REG_SZ, domain)
            # end if
        # end with
    # end func

    def disable_autologon(self):
        with self._open_key(winreg.KEY_SET_VALUE) as key:
            winreg.SetValueEx(key, "AutoAdminLogon", 0, winreg.REG_SZ, "0")
            # you can either delete all autologon values or just the default password
            for val in self.AUTOLOGON_VALUES:
                try:
                    winreg.DeleteValue(key, val)
                except FileNotFoundError:
                    pass
                # end try
            # end for
        # end with
    # end func
# end class