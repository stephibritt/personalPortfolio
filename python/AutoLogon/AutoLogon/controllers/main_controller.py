import sys, getpass, os, ctypes
from tkinter import messagebox

class MainController:
    def __init__(self, view, model):
        self.view = view
        self.model = model

        self.ensure_admin()

        username = getpass.getuser()
        self.view.update_username(username)

        domain = os.environ.get("USERDOMAIN")
        self.view.update_domain(domain)
        
        self.view.enable_btn.config(command=self.handle_enable)
        self.view.disable_btn.config(command=self.handle_disable)
        self.view.close_btn.config(command=self.handle_close)
    # end init

    def handle_enable(self):
        username = self.view.get_username()
        password = self.view.get_password()
        domain = self.view.get_domain()
        self.model.enable_autologon(username, password, domain)
        messagebox.showinfo("Enable", "Auto Logon Enabled!")
        # messagebox.showinfo("Enable", f"Username: {username}\nPassword: {password}\nDomain: {domain}")
    # end func

    def handle_disable(self):
        self.model.disable_autologon()
        messagebox.showinfo("Disable", "Auto Logon Disabled!")
    # end func

    def handle_close(self):
        sys.exit()
    # end func

    def ensure_admin(self):
        """
        Relaunch the program with administrator rights if not already elevated.
        Shows a UAC prompt if needed.
        """
        try:
            is_admin = ctypes.windll.shell32.IsUserAnAdmin()
        except:
            is_admin = False

        if not is_admin:
            # Re-run with admin privileges
            params = " ".join([f'"{arg}"' for arg in sys.argv])
            ctypes.windll.shell32.ShellExecuteW(
                None, "runas", sys.executable, params, None, 1
            )
            sys.exit()  # Kill the unelevated instance
    # end func
# end class