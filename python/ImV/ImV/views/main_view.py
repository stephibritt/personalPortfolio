import tkinter as tk
from importlib import resources

class MainView(tk.Tk):
    def __init__(self, app_name, version):
        super().__init__()

        # this is in a try statement in case the .ico file cannot be found
        try:
            with resources.path("ImV.resources", "image_viewer.ico") as icon_path:
                self.iconbitmap(icon_path)
            # end with
        except:
            # do nothing and simply do not use the icon
            pass
        # end try
        
        self.title(f"{app_name} v{version}")
        self.attributes("-topmost", True)

        # this is the minimum size that will show the buttons correctly
        self.min_width = 317
        self.min_height = 26
        self.minsize(self.min_width, self.min_height)

        # MENUBAR
        self.menubar = tk.Menu(self)

        # FILE MENU
        self.file_menu = tk.Menu(self.menubar, tearoff=0)
        self.file_menu.add_command(label="Open Image")
        self.file_menu.add_command(label="Remove Image")
        self.file_menu.add_command(label="Restore Default Image Size")
        self.file_menu.add_command(label="Stretch Image to Frame")
        self.file_menu.add_separator()
        self.file_menu.add_command(label="Exit", )
        
        # SETTINGS MENU
        self.on_top_checked = tk.BooleanVar()
        self.resizable_checked = tk.BooleanVar()
        self.borderless_checked = tk.BooleanVar()
        self.tool_win_checked = tk.BooleanVar()

        self.settings_menu = tk.Menu(self.menubar, tearoff=0)
        self.settings_menu.add_command(label="Reset Defaults")
        self.settings_menu.add_separator()
        self.settings_menu.add_checkbutton(label="Always On Top", variable=self.on_top_checked)
        self.settings_menu.add_checkbutton(label="Borderless", variable=self.borderless_checked)
        self.settings_menu.add_checkbutton(label="Resizable", variable=self.resizable_checked)
        self.settings_menu.add_checkbutton(label="Tool Window Mode", variable=self.tool_win_checked)
        self.settings_menu.add_separator()
        self.settings_menu.add_command(label="User Settings")

        # HELP MENU
        self.help_menu = tk.Menu(self.menubar, tearoff=0)
        self.help_menu.add_command(label="About")
        self.help_menu.add_command(label="Tips")

        # MENUBAR ORDER
        self.menubar.add_cascade(label="File", menu=self.file_menu)
        self.menubar.add_cascade(label="Settings", menu=self.settings_menu)
        self.menubar.add_cascade(label="Help", menu=self.help_menu)

        self.config(menu=self.menubar)

        self.buttons_frame = tk.Frame(self)

        # QUICK ACCESS BUTTONS
        self.on_top_btn = tk.Checkbutton(
            self.buttons_frame,
            text="Always On Top",
            variable=self.on_top_checked
        )

        self.open_image_btn = tk.Button(
            self.buttons_frame,
            text="Open Image"
        )
        
        self.stretch_img_btn = tk.Button(
            self.buttons_frame,
            text="Stretch Image to Frame"
        )

        self.on_top_btn.pack(side="left", fill="y")
        self.open_image_btn.pack(side="left")
        self.stretch_img_btn.pack(side="left")

        self.buttons_frame.pack()

        # IMAGE DISPLAY
        self.image_frame = tk.Frame(self)
        self.image_frame.pack()

        self.image_area = tk.Label(self.image_frame)
        self.image_area.pack()

        self.image_border = 4 # this will be used by the controller to ensure size alterations are correct

        # START POSITION
        self.update_idletasks()
        self.geometry("+25+25")
    #  end init

    def display_image(self, tk_image):
        self.image_area.forget()

        if tk_image is None:
            self.image_area = tk.Label(
                self.image_frame,
                text="No image selected.",
                fg="black"
            )
        else:
            self.image_area = tk.Label(
                self.image_frame,
                image=tk_image
            )

            self.image_area.image = tk_image
        # end if

        self.image_area.pack(fill="x")

        self.update_idletasks()
        self.geometry("")
    # end func
# end class