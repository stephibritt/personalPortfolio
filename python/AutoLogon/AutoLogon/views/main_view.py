import tkinter as tk

class MainView(tk.Tk):
    def __init__(self, app_name, version):
        super().__init__()

        # entry form
        self.title(f"{app_name} v{version}")
        self.resizable(False, False)

        self.groupbox_frame = tk.Frame(self)
        self.groupbox_frame.pack(padx=8, anchor='w')

        self.username_label = tk.Label(self.groupbox_frame, text="Username:", anchor='w')
        self.username_label.pack(anchor='w')

        self.username_entry = tk.Entry(self.groupbox_frame, width=25, relief='sunken', bd=2)
        self.username_entry.pack(anchor='w')

        self.password_label = tk.Label(self.groupbox_frame, text="Password:", anchor='w')
        self.password_label.pack(anchor='w')

        self.password_entry = tk.Entry(self.groupbox_frame, width=25, relief='sunken', bd=2)
        self.password_entry.pack(anchor='w')

        self.domain_label = tk.Label(self.groupbox_frame, text="Domain:", anchor='w')
        self.domain_label.pack(anchor='w')

        self.domain_entry = tk.Entry(self.groupbox_frame, width=25, relief='sunken', bd=2)
        self.domain_entry.pack(anchor='w')

        # buttons
        self.buttons_frame = tk.Frame(self)
        self.buttons_frame.pack()

        self.enable_btn = tk.Button(self.buttons_frame, text="Enable", width=9)
        self.enable_btn.pack(side='left', padx=5, pady=4)

        self.disable_btn = tk.Button(self.buttons_frame, text="Disable", width=9)
        self.disable_btn.pack(side='left', padx=6, pady=4)

        self.close_btn = tk.Button(self.buttons_frame, text="Close", width=9)
        self.close_btn.pack(side='left', padx=5, pady=4)
    # end init

    
    def get_username(self):
        return self.username_entry.get()
    # end func

    def get_password(self):
        return self.password_entry.get()
    # end func

    def get_domain(self):
        return self.domain_entry.get()
    # end func
    
    def update_username(self, new_username):
        self.username_entry.delete(0, "end")
        self.username_entry.insert(0, new_username)
    # end func
    
    def update_domain(self, new_domain):
        self.domain_entry.delete(0, "end")
        self.domain_entry.insert(0, new_domain)
    # end func
# end class