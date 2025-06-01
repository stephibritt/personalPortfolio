import tkinter
from tkinter import filedialog
import os
from PIL import Image, ImageTk, ImageGrab

def Main():
    image_viewer = ImageViewer()
# end main

class ImageViewer:
    def __init__(self) -> None:
        # create the main window
        self.mainWindow = tkinter.Tk()
        self.mainWindow.iconbitmap("image_viewer.ico")
        self.mainWindow.title("Image Viewer")
        self.mainWindow.attributes("-topmost", True)

        # create the frames
        self.buttonsFrame = tkinter.Frame(self.mainWindow)
        self.imageFrame = tkinter.Frame(self.mainWindow)

        # create the buttons
        self.onTopChecked = tkinter.BooleanVar()
        self.onTopChecked.set(True)
        self.onTopBtn = tkinter.Checkbutton(self.buttonsFrame, text="Always On Top", command=self.toggleOnTop, variable=self.onTopChecked)
        self.chooseImgBtn = tkinter.Button(self.buttonsFrame, text="Choose Image", command=self.changeImage)

        self.onTopBtn.pack(side="left")
        self.chooseImgBtn.pack(side="left")
        
        img = self.chooseImage()
        self.imageArea = tkinter.Label(self.imageFrame, image=img)
        self.imageArea.pack()

        self.buttonsFrame.pack()
        self.imageFrame.pack()

        tkinter.mainloop()
    # end func

    def changeImage(self):
        # forget the previous image
        self.imageArea.pack_forget()

        # select a new image and repack the frame
        img = self.chooseImage()
        self.imageArea = tkinter.Label(self.imageFrame, image=img)
        self.imageArea.pack()

        self.buttonsFrame.pack()
        self.imageFrame.pack()

        tkinter.mainloop()
    # end func
    
    def toggleOnTop(self):
        if self.onTopChecked.get():
            self.mainWindow.attributes("-topmost", True)
        else:
            self.mainWindow.attributes("-topmost", False)
        # end if
    # end func
    
    def chooseImage(self):
        # python supports the relative path using ~ to denote the current user's home folder
        screenshotDirectory = "~/Pictures/Screenshots"
        
        file_path = filedialog.askopenfilename(title="Image To Show", initialdir=screenshotDirectory)
        
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
        
        return img
    # end func
# end class
            
# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    Main()
# end if