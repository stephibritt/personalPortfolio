from tkinter import filedialog
from ImV import __app_name__
from pathlib import Path

class SettingsController:
    def __init__(self, view, model):
        self.view = view
        self.model = model

        # Attach the button callback properly
        self.view.start_prompt_btn.config(command=self.handle_toggle_start_prompt)
        self.view.browse_btn.config(command=self.handle_browse)

        # set saved user settings
        saved_start_prompt = self.model.get_bool("General", "prompt_on_start")
        self.view.prompt_checked.set(saved_start_prompt)

        saved_dir = self.model.get("General", "open_image_start_dir", str(Path.home() / "Pictures" / "Screenshots"))
        self.view.update_dir_entry(saved_dir)

        # optional: make view modal (blocks interaction with parent until closed)
        self.view.transient(self.view.master)
        self.view.grab_set()
    # end init

    def handle_toggle_start_prompt(self):
        # get current setting as string, convert to bool
        current_setting = self.model.get_bool("General", "prompt_on_start")

        # toggle
        new_setting = not current_setting

        # update model
        self.model.set("General", "prompt_on_start", str(new_setting))

        # update view
        self.view.prompt_checked.set(new_setting)
    # end func


    def handle_browse(self):
        # get user input
        new_user_dir = filedialog.askdirectory()

        if new_user_dir:  # only update if the user actually picked a folder
            self.view.update_dir_entry(new_user_dir)
            self.model.set("General", "open_image_start_dir", new_user_dir)  # save to model
        # end if
    # end func
# end class