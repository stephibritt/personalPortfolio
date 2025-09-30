from ImV.views.main_view import MainView
from ImV.controllers.main_controller import MainController
from ImV.models.image_manager import ImageManager
from ImV.models.settings_manager import SettingsManager
from ImV import __app_name__, __version__

def main():
    view = MainView(__app_name__, __version__)
    model = ImageManager()
    settings_model = SettingsManager(__app_name__)
    controller = MainController(view, model, settings_model)
    view.mainloop()
# end main

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if