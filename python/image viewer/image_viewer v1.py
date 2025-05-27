import tkinter as tk
from tkinter import filedialog
import os
from PIL import Image, ImageTk, ImageGrab
import win32clipboard

os.chdir("C:\\Users\\RTS Tech\\Desktop\\Notes\\Scripts and Programs\\Josh's Stuff")
print(os.getcwd())

#Set up root window & Get file to show
root = tk.Tk()
root.iconbitmap("image_viewer.ico")
root.title("ImV")

screenshotDirectory = "C:\\Users\\RTS Tech\\Pictures\\Screenshots"

file_path = filedialog.askopenfilename(title="Image To Show", initialdir=screenshotDirectory)
img = None
print(f"file_path: \'{file_path}\'")
if os.path.isdir(file_path) or len(file_path)==0:
    try:
        img = ImageTk.PhotoImage(ImageGrab.grabclipboard())
    except KeyError:
        print("KeyError, no key supplied to reference with. Quitting...")
        quit()
    except AttributeError:
        print("AttributeError, unable to use clipboard data. Quitting...")
        quit()
    # end try
else:
    try:
        img = ImageTk.PhotoImage(Image.open(file_path))
    except PermissionError:
        print("PermissionError, unable to access media. Quitting...")
        quit()
    # end try
# end if

root.attributes('-topmost', True)

#Define on_top toggle function for button
on_top_text = "On Top: "
on_top = True
def toggle_on_top():
    global on_top
    if on_top:
        root.attributes('-topmost', False)
        on_top = False
        on_top_button_tv.set(on_top_text + "Disabled")
    else:
        root.attributes('-topmost', True)
        on_top = True
        on_top_button_tv.set(on_top_text + "Enabled")
    # end if
# end func

frame = tk.Frame(root)
frame.pack()

on_top_button_tv = tk.StringVar()
on_top_button_tv.set(on_top_text + "Enabled")
on_top_button = tk.Button(frame, textvariable=on_top_button_tv, command=toggle_on_top)
on_top_button.pack()

#For scaling images. Will need to copy image data (held in img) to scale from
#       so you don't modify original image data so scaling again to a higher res won't look as janky
# scale_button = tk.Button(root, text="Scale Image")

image_viewer = tk.Label(frame, image = img)
image_viewer.pack()

root.mainloop()