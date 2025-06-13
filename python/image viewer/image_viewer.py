import tkinter
from tkinter import filedialog
import os
import PIL
from PIL import Image, ImageTk, ImageGrab

def Main():
    image_viewer = ImageViewer()
# end main

class ImageViewer:
    def __init__(self) -> None:
        # create the main window
        self.mainWindow = tkinter.Tk()

        # for some reason this throws an error in debug mode. I am putting it in a try loop to mitigate that. It works when run via the batch file.
        try:
            self.mainWindow.iconbitmap("image_viewer.ico")
        except:
            # do nothing
            pass
        # end try
        
        self.mainWindow.title("ImV")
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

        self.buttonsFrame.pack()
        
        # populate the image area
        self.setImage()        
    # end func

    def changeImage(self):
        # forget the previous image
        try:
            self.imageArea.forget()
        except:
            # do nothing if it fails, this likely means an image was never packed
            pass
        # end try

        # select a new image and repack the frame
        self.setImage()
    # end func
    
    def toggleOnTop(self):
        if self.onTopChecked.get():
            self.mainWindow.attributes("-topmost", True)
        else:
            self.mainWindow.attributes("-topmost", False)
        # end if
    # end func
    
    def getImage(self):
        # python supports the relative path using ~ to denote the current user's home folder
        screenshotDirectory = "~/Pictures/Screenshots"
        
        file_path = filedialog.askopenfilename(title="Image To Show", initialdir=screenshotDirectory)

        img = None
        
        if os.path.isdir(file_path) or len(file_path)==0:
            try:
                img = ImageTk.PhotoImage(ImageGrab.grabclipboard())
            except KeyError:
                print("KeyError: No key supplied to reference with. Returning None.")
            except AttributeError:
                print("AttributeError: Unable to use clipboard data. Returning None.")
            except ValueError:
                print("ValueError: Nothing chosen and no image in clipboard. Returning None.")
            except:
                print("Unknown Error: An unknown error occurred. Returning None.")
            # end try
        else:
            try:
                img = ImageTk.PhotoImage(Image.open(file_path))
            except PermissionError:
                print("PermissionError: Unable to access media. Returning None.")
            except PIL.UnidentifiedImageError: 
                print("PIL.UnidentifiedImageError: Cannot identify image file. Returning None.")
            except:
                print("Unknown Error: An unknown error occurred. Returning None.")
            # end try
        # end if
        
        return img
    # end func

    def setImage(self):
        # select a new image and repack the frame
        img = self.getImage()

        # either assign the image or if it returns as None, label it as no image selected.
        if img is None:
            self.imageArea = tkinter.Label(self.imageFrame, text="No image selected.", fg="black")
        else:
            self.imageArea = tkinter.Label(self.imageFrame, image=img)
        # end if

        self.imageArea.pack()

        self.imageFrame.pack()

        # build the window
        tkinter.mainloop()
    # end func
# end class
            
# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    Main()
# end if