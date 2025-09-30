import tkinter as tk
from importlib import resources

class SettingsView(tk.Toplevel):
    def __init__(self, parent):
        super().__init__(parent)  # parent = main app window
        self.title("User Settings")
        self.attributes("-topmost", True)
        self.resizable(False, False)

        # this is in a try statement in case the .ico file cannot be found
        try:
            with resources.path("ImV.resources", "image_viewer.ico") as icon_path:
                self.iconbitmap(icon_path)
            # end with
        except:
            # do nothing and simply do not use the icon
            pass
        # end try

        self.buttons_frame = tk.Frame(self)

        # start prompt setting
        self.prompt_checked = tk.BooleanVar()

        self.start_prompt_btn = tk.Checkbutton(self.buttons_frame, text="Prompt for Image on Start", variable=self.prompt_checked)

        self.start_prompt_btn.pack(side="top", pady=5, anchor="w")

        # directoy settings
        self.dir_frame = tk.Frame(self.buttons_frame)

        self.dir_label = tk.Label(self.dir_frame, text="Open Image Starting Directory:", anchor="w")

        self.dir_label.pack(side="top", anchor="w")

        self.dir_entry = tk.Entry(self.dir_frame, relief="sunken", bd=2, width=40, state="readonly")

        self.dir_entry.pack(side="left", fill="both", expand=True)


        self.browse_btn = tk.Button(self.dir_frame, text="Browse")

        self.browse_btn.pack(side="right", fill="both")

        # inner frame pack
        self.dir_frame.pack(fill="x", pady=5)

        # outer frame pack
        self.buttons_frame.pack(padx=10, pady=10)

        # center user settings
        self.update_idletasks()
        x_offset = (self.winfo_screenwidth() // 2) - (self.winfo_reqwidth())
        y_offset = (self.winfo_screenheight() // 2) - (self.winfo_reqheight()) - 50
        self.geometry(f"+{x_offset}+{y_offset}")
    # end init

    def update_dir_entry(self, new_path):
        self.dir_entry.config(state="normal")
        self.dir_entry.delete(0, "end")
        self.dir_entry.insert(0, new_path)
        self.dir_entry.config(state="readonly")
    # end func
# end class
