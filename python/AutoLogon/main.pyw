from AutoLogon import __app_name__, __version__
from AutoLogon.views.main_view import MainView
from AutoLogon.models.registry_manager import RegistryManager
from AutoLogon.controllers.main_controller import MainController

def main():
    view = MainView(__app_name__, __version__)
    model = RegistryManager()
    controller = MainController(view, model)
    view.mainloop()
# end main

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if