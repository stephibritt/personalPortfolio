from PIL import Image, ImageGrab, UnidentifiedImageError
from tkinter import filedialog
import os

class ImageManager:
    def __init__(self):
        self.current_image = None
        # self.tk_image = None  # Cached for Tkinter display
    # end init

    def get_image(self, start_dir):
        self.image_path = filedialog.askopenfilename(
            title="Image To Show",
            initialdir=start_dir
        )

        try:
            if not self.image_path or os.path.isdir(self.image_path):
                # Grab image from clipboard
                img = ImageGrab.grabclipboard()
            else:
                # Load image from file
                img = Image.open(self.image_path)
            # end if

            if img is None:
                return None
            # end if

            self.current_image = img

            return img
        except (KeyError, AttributeError, ValueError, PermissionError, UnidentifiedImageError):
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

    def resize_image(self, win_width, win_height, min_win_height):
        if self.current_image is None:
            return None
        # end if

        resize_width = win_width - 4
        resize_height = win_height - min_win_height - 4

        return self.current_image.resize((resize_width, resize_height), Image.LANCZOS)
    # end func
# end class