import tkinter
from tkinter import filedialog, messagebox
import os
import PIL
from PIL import Image, ImageTk, ImageGrab
import sys
import getpass
from ImV import __app_name__, __version__
from importlib import resources

def main():
    ImageViewer()
# end main

class ImageViewer:
    def __init__(self) -> None:
        # create the main window
        self.main_window = tkinter.Tk()
        # __version__ = "0.1.0"

        # this is in a try statement in case the .ico file cannot be found
        try:
            with resources.path("ImV.resources", "image_viewer.ico") as icon_path:
                self.main_window.iconbitmap(icon_path)
            # end with
        except:
            # do nothing and simply do not use the icon
            pass
        # end try
        
        self.main_window.title(f"{__app_name__} v0.1.1")
        self.main_window.attributes("-topmost", True)

        # this is the minimum size that will show the buttons correctly
        self.min_width = 317
        self.min_height = 26
        self.main_window.minsize(self.min_width, self.min_height)

        current_user = getpass.getuser()

        app_data_path = f"C:\\Users\\{current_user}\\AppData\\Local\\Programs\\ImV\\"

        if not os.path.isdir(app_data_path):
            os.mkdir(app_data_path)
        # end if

        self.settings_file = app_data_path + "settings.ini"

        # Menu to open an image
        menubar = tkinter.Menu(self.main_window)
        file_menu = tkinter.Menu(menubar, tearoff=0)
        file_menu.add_command(label="Open Image", command=self.open_image)
        file_menu.add_command(label="Remove Image", command=self.remove_image)
        file_menu.add_command(label="Restore Default Image Size", command=self.restore_def_img_size)
        file_menu.add_command(label="Stretch Image to Frame", command=self.stretch_image)
        file_menu.add_separator()
        file_menu.add_command(label="Close", command=sys.exit)

        # default true values
        self.on_top_checked = tkinter.BooleanVar(value=True)
        self.resizable_checked = tkinter.BooleanVar(value=True)

        # default false values
        self.borderless_checked = tkinter.BooleanVar(value=False)
        self.tool_win_checked = tkinter.BooleanVar(value=False)

        # startup settings
        try:
            self.prompt_at_start = self.get_startup_settings()

            if type(self.prompt_at_start) != bool:
                self.prompt_at_start = False
            # end if
        except:
            # if anything unexpected happens, set it to false
            self.prompt_at_start = False
        # end try

        self.start_prompt_checked = tkinter.BooleanVar(value=self.prompt_at_start)

        settings_menu = tkinter.Menu(menubar, tearoff=0)
        settings_menu.add_command(label="Reset Defaults", command=self.reset_defaults)
        settings_menu.add_separator()
        settings_menu.add_checkbutton(label="Always On Top", command=self.toggle_on_top, variable=self.on_top_checked)
        settings_menu.add_checkbutton(label="Borderless", command=self.toggle_borderless, variable=self.borderless_checked)
        settings_menu.add_checkbutton(label="Resizable", command=self.toggle_resizable, variable=self.resizable_checked)
        settings_menu.add_checkbutton(label="Tool Window Mode", command=self.toggle_tool_window, variable=self.tool_win_checked)
        settings_menu.add_separator()
        settings_menu.add_checkbutton(label="Prompt for Image at Start", command=self.set_startup_settings, variable=self.start_prompt_checked)

        about_menu = tkinter.Menu(menubar, tearoff=0)
        about_menu.add_command(label="About the developers", command=self.show_dev_info)
        about_menu.add_command(label="Tips and Tricks", command=self.show_tips)

        menubar.add_cascade(label="File", menu=file_menu)
        menubar.add_cascade(label="Settings", menu=settings_menu)
        menubar.add_cascade(label="About", menu=about_menu)
        self.main_window.config(menu=menubar)

        # create the frames
        self.buttons_frame = tkinter.Frame(self.main_window)
        self.image_frame = tkinter.Frame(self.main_window)

        # create the buttons
        self.on_top_btn = tkinter.Checkbutton(self.buttons_frame, text="Always On Top", command=self.toggle_on_top, variable=self.on_top_checked)
        self.open_image_btn = tkinter.Button(self.buttons_frame, text="Open Image", command=self.open_image)
        self.stretch_img_btn = tkinter.Button(self.buttons_frame, text="Stretch Image to Frame", command=self.stretch_image)

        self.on_top_btn.pack(side="left")
        self.open_image_btn.pack(side="left")
        self.stretch_img_btn.pack(side="left")

        self.buttons_frame.pack()

        self.main_window.update_idletasks()
        self.main_window.geometry("+25+25")
        
        # populate the image area
        self.set_image(self.prompt_at_start)
    # end func

    def get_startup_settings(self):
        try:
            with open(self.settings_file, 'r', encoding='utf-8') as infile:
                return infile.readline().strip() == "True"
            # end with
        except FileNotFoundError:
            return False  # default if file is missing
        # end try
    # end func

    def set_startup_settings(self):
        # default value if file doesn't exist or is empty
        prompt_setting = "False"

        try:
            with open(self.settings_file, 'r', encoding='utf-8') as infile:
                prompt_setting = infile.readline().strip() or "False"
            # end with
        except FileNotFoundError:
            pass  # use default
        # end try

        # toggle value
        new_value = "False" if prompt_setting == "True" else "True"

        # update tkinter variable
        self.start_prompt_checked.set(new_value == "True")

        # write back to file
        with open(self.settings_file, 'w', encoding='utf-8') as outfile:
            outfile.write(new_value)
        # end with
    # end func

    def open_image(self):
        # this function exists because you can't pass pass a parameter in the command of a button
        # select a new image and repack the frame
        self.set_image(True)
    # end func

    def remove_image(self):
        self.set_image(False)
    # end func

    def stretch_image(self):
        # forget the previous image
        try:
            self.image_area.forget()
        except:
            # do nothing if it fails
            pass
        # end try

        original_image_path = self.image_path

        if original_image_path == "":
            self.remove_image()
            return
        # end if

        original_image = Image.open(original_image_path)
        resize_width = self.main_window.winfo_width() - 4
        resize_height = self.main_window.winfo_height() - self.min_height - 4

        resized = original_image.resize((resize_width, resize_height), Image.LANCZOS)
        new_image = ImageTk.PhotoImage(resized)

        self.image_area.config(image=new_image)

        self.image_area.pack()

        self.image_frame.pack()

        # build the window
        tkinter.mainloop()
    # end func

    def restore_def_img_size(self):
        # forget the previous image
        try:
            self.image_area.forget()
        except:
            # do nothing if it fails
            pass
        # end try

        original_image_path = self.image_path

        if original_image_path == "":
            self.remove_image()
            return
        # end if

        original_image = Image.open(original_image_path)
        
        new_image = ImageTk.PhotoImage(original_image)

        self.image_area.config(image=new_image)

        self.image_area.pack()

        self.image_frame.pack()

        self.main_window.update_idletasks()
        self.main_window.geometry(f"") # this directs the window to resize base on its contents

        # build the window
        tkinter.mainloop()
    # end func
    
    def toggle_on_top(self):
        if self.main_window.attributes("-topmost"):
            self.on_top_checked.set(False)
            self.main_window.attributes("-topmost", False)
        else:
            self.on_top_checked.set(True)
            self.main_window.attributes("-topmost", True)
        # end if
    # end func
    
    def toggle_tool_window(self):
        if self.main_window.attributes("-toolwindow"):
            self.main_window.attributes("-toolwindow", False)
        else:
            self.main_window.attributes("-toolwindow", True)
        # end if
    # end func
    
    def toggle_resizable(self):
        w_resizable, h_resizable = self.main_window.resizable()
        if w_resizable and h_resizable:
            self.main_window.resizable(False, False)
        else:
            self.main_window.resizable(True, True)
    # end func

    def toggle_borderless(self):
        if self.main_window.overrideredirect():
            self.main_window.overrideredirect(False)
        else:
            self.main_window.overrideredirect(True)
        # end if
    # end func

    def reset_defaults(self):
        # default true values
        self.on_top_checked.set(True)
        self.main_window.attributes("-topmost", True)

        self.resizable_checked.set(True)
        self.main_window.resizable(True, True)

        # default false values
        self.borderless_checked.set(False)
        self.main_window.overrideredirect(False)

        self.tool_win_checked.set(False)
        self.main_window.attributes("-toolwindow", False)

        # set image to none
        self.main_window.update_idletasks()
        self.main_window.geometry(f"") # this directs the window to resize base on its contents
        # self.set_image(False)
    # end func
    
    def get_image(self):
        # python supports the relative path using ~ to denote the current user's home folder
        screenshotDirectory = "~/Pictures/Screenshots"
        
        self.image_path = filedialog.askopenfilename(title="Image To Show", initialdir=screenshotDirectory)

        img = None
        
        if os.path.isdir(self.image_path) or len(self.image_path)==0:
            try:
                img = ImageTk.PhotoImage(ImageGrab.grabclipboard())
            except KeyError:
                print("KeyError: No key supplied to reference with. Returning None.")
            except AttributeError:
                print("AttributeError: Unable to use clipboard data. Returning None.")
            except ValueError:
                print("ValueError: Nothing chosen and no image in clipboard. Returning None.")
            # end try
        else:
            try:
                img = ImageTk.PhotoImage(Image.open(self.image_path))
            except PermissionError:
                print("PermissionError: Unable to access media. Returning None.")
            except PIL.UnidentifiedImageError: 
                print("PIL.UnidentifiedImageError: Cannot identify image file. Returning None.")
            # end try
        # end if
        
        return img
    # end func

    def set_image(self, suppress_choice=False):
        # forget the previous image
        try:
            self.image_area.forget()
        except:
            # do nothing if it fails
            pass
        # end try

        # select a new image and repack the frame
        if suppress_choice:
            img = self.get_image()
        else:
            img = None
            self.image_path = ""
        # end if

        # either assign the image or if it returns as None, label it as no image selected.
        if img is None:
            self.image_area = tkinter.Label(self.image_frame, text="No image selected.", fg="black")
        else:
            self.image_area = tkinter.Label(self.image_frame, image=img)
        # end if

        self.image_area.pack()

        self.image_frame.pack()

        self.main_window.update_idletasks()
        self.main_window.geometry(f"") # this directs the window to resize base on its contents

        # messagebox.showinfo("Size", f"Width: {self.main_window.winfo_width()}\nHeight: {self.main_window.winfo_height()}")

        # build the window
        tkinter.mainloop()
    # end func

    def show_tips(self):
        
        tips_msg = (
            "There are more settings than the three quick access buttons, so explore the menus!\n\n"
            "• Stretching the image: Use the drag handles on the edge of the window to set the desired size, "
            "then simply press the quick access 'Stretch Image to Frame' button."
        )

        messagebox.showinfo("Tips and Tricks", tips_msg)
    # end func

    def show_dev_info(self):
        first_dev = "Dev0"
        second_dev = "Dev1"

        dev_info_msg = (
            f"{first_dev} created this as a neat tool to view images on top of other programs that take focus "
            f"or block off the screen. Originally, you could only select one image at startup and had to close it to change the image. "
            f"\n\n{second_dev} later added the other functionality, such as the menus, resizing options, and the ability to change images."
        )

        messagebox.showinfo("Dev Info", dev_info_msg)
    # end func
# end class

            
# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if