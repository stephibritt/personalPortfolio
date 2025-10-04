# EXTERNAL IMPORTS
from tkinter import messagebox
from PIL import ImageTk
import sys
from pathlib import Path

from ImV import __app_name__

# SETTINGS IMPORTS
from ImV.views.settings_view import SettingsView
from ImV.controllers.settings_controller import SettingsController

class MainController:
    def __init__(self, view, model, settings_model):
        self.view = view
        self.model = model
        self.settings_model = settings_model

        # FILE MENU HANDLERS
        self.view.file_menu.entryconfig("Open Image", command=self.handle_open_image)
        self.view.file_menu.entryconfig("Remove Image", command=self.handle_remove_image)
        self.view.file_menu.entryconfig("Restore Default Image Size", command=self.handle_restore_size)
        self.view.file_menu.entryconfig("Stretch Image to Frame", command=self.handle_stretch_image)
        self.view.file_menu.entryconfig("Exit", command=self.handle_exit)

        # SETTINGS MENU HANDLERS
        self.view.settings_menu.entryconfig("Reset Defaults", command=self.handle_reset_defaults)
        self.view.settings_menu.entryconfig("Always On Top", command=self.handle_toggle_on_top)
        self.view.settings_menu.entryconfig("Borderless", command=self.handle_toggle_borderless)
        self.view.settings_menu.entryconfig("Resizable", command=self.handle_toggle_resizable)
        self.view.settings_menu.entryconfig("Tool Window Mode", command=self.handle_toggle_tool_window)
        self.view.settings_menu.entryconfig("User Settings", command=self.handle_user_settings)

        # ABOUT MENU HANDLERS
        self.view.help_menu.entryconfig("About", command=self.handle_about)
        self.view.help_menu.entryconfig("Tips", command=self.handle_tips)

        # QUICK ACCESS BUTTON HANDLERS
        self.view.on_top_btn.config(command=self.handle_toggle_on_top)
        self.view.open_image_btn.config(command=self.handle_open_image)
        self.view.stretch_img_btn.config(command=self.handle_stretch_image)

        self.handle_reset_defaults()

        # temporary until settings working
        start_prompt_setting = self.settings_model.get_bool("General", "prompt_on_start")

        if start_prompt_setting:
            self.handle_open_image()
        else:
            self.view.display_image(None)
        # end if
    # end init

    # FILE MENU FUNCTIONS
    def handle_open_image(self):
        default_dir = Path.home() / "Pictures" / "Screenshots"
        saved_start_dir = Path(self.settings_model.get("General", "open_image_start_dir", fallback=str(default_dir)))

        start_dir = saved_start_dir if saved_start_dir.is_dir() else default_dir

        user_image = self.model.get_image(start_dir)

        image_for_display = ImageTk.PhotoImage(user_image) if user_image else None

        self.view.display_image(image_for_display)
    # end func

    def handle_remove_image(self):
        self.model.remove_image()

        self.view.display_image(None)
    # end func
    
    def handle_restore_size(self):
        original_image = self.model.load_image()
        
        image_for_display = ImageTk.PhotoImage(original_image) if original_image else None
        
        self.view.display_image(image_for_display)
    # end func
    
    def handle_stretch_image(self):
        win_width = self.view.winfo_width()
        win_height = self.view.winfo_height()
        min_win_height = self.view.min_height
        image_border = self.view.image_border

        resized_image = self.model.resize_image(win_width, win_height, min_win_height, image_border)
        
        image_for_display = ImageTk.PhotoImage(resized_image) if resized_image else None
        
        self.view.display_image(image_for_display)
    # end func

    def handle_exit(self):
        sys.exit()
    # end func

    # SETTINGS MENU FUNCTIONS
    def handle_reset_defaults(self):
        # default true values
        self.view.on_top_checked.set(True)
        self.view.attributes("-topmost", True)

        self.view.resizable_checked.set(True)
        self.view.resizable(True, True)

        # default false values
        self.view.borderless_checked.set(False)
        self.view.overrideredirect(False)

        self.view.tool_win_checked.set(False)
        self.view.attributes("-toolwindow", False)

        # set image to none
        self.view.update_idletasks()
        self.view.geometry(f"") # this directs the window to resize base on its contents
    # end func

    def handle_toggle_on_top(self):
        self.view.attributes("-topmost", not bool(self.view.attributes("-topmost")))
    # end func

    def handle_toggle_borderless(self):
        self.view.overrideredirect(not self.view.overrideredirect())
    # end func

    def handle_toggle_resizable(self):
        self.view.resizable(*[not flag for flag in self.view.resizable()])
    # end func

    def handle_toggle_tool_window(self):
        self.view.attributes("-toolwindow", not bool(self.view.attributes("-toolwindow")))
    # end func

    def handle_user_settings(self):
        settings_parent = self.view

        settings_view = SettingsView(settings_parent)
        settings_controller = SettingsController(settings_view, self.settings_model)
        settings_view.mainloop()
    # end func

    # ABOUT MENU FUNCTIONS
    def handle_about(self):
        messagebox.showinfo(
            "About",
            "Image Viewer\n\nThis app started out as a neat project to view images "
            "on top of other windows or apps that maintain focus.\n\n"
            "Originally, you were prompted on startup to select an image that would display "
            "with no option to change or resize images.\n\n"
            "Functionality was later added to change the selected image and to resize based on the window size."
            "This change also introduced quite a bit more complexity and error handling."
        )
    # end func

    def handle_tips(self):
        messagebox.showinfo(
            "Tips",
            "There are more settings than the three quick access buttons, so explore the menus!\n\n"
            "• Stretching the image:\n" \
            "Use the drag handles on the edge of the window to set" \
            "the desired size, then simply press the quick access 'Stretch Image to Frame' button."
        )
    # end func
# end class