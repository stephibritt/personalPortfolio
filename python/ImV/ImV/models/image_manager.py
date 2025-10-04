from PIL import Image, ImageGrab, UnidentifiedImageError
from tkinter import filedialog
import os

class ImageManager:
    def __init__(self):
        self.current_image = None
        # self.tk_image = None  # Cached for Tkinter display
    # end init

    def get_image(self, start_dir):
        image_path = filedialog.askopenfilename(
            title="Image To Show",
            initialdir=start_dir
        )

        try:
            if not image_path or os.path.isdir(image_path):
                # Grab image from clipboard
                img = ImageGrab.grabclipboard()
            else:
                # Load image from file
                img = Image.open(image_path)
            # end if

            self.current_image = img

            if img is None:
                return None
            # end if

            return img
        except (KeyError, AttributeError, ValueError, PermissionError, UnidentifiedImageError) as ex:
            print(ex)
            return None
        # end try
    # end func

    def remove_image(self):
        self.current_image = None
    # end func

    def load_image(self):
        if self.current_image is None:
            return None
        # end if

        return self.current_image
    # end func

    def resize_image(self, win_width, win_height, min_win_height, image_border):
        if self.current_image is None:
            return None
        # end if

        # without the image border width and height, this will alter the image size if the window is not resized
        resize_width = win_width - image_border
        resize_height = win_height - min_win_height - image_border

        return self.current_image.resize((resize_width, resize_height), Image.LANCZOS)
    # end func
# end class