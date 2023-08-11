#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 8/11/2023
#================================================================================#

import os
import qrcode

def main():
    repeat = "Y"
    while repeat.upper() == "Y":
        urlText = "https://www."
        urlText += input("Enter the URL you wish to encode (exclude prefixes): ")
        fileName = input("Enter the filename to save the QR code (with extension, e.g., 'qrcode.png'): ")

        generate_qr_code(urlText, fileName)
        
        print(f"QR code saved on your desktop as {fileName}")
        
        repeat = input("\nWould you like to generate another code? (Y/n): ")
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to generate another code? (Y/n): ")
        # end while
    # end while
# end function

def generate_qr_code(urlText, fileName):
    qr = qrcode.QRCode(
        version=1,
        error_correction=qrcode.constants.ERROR_CORRECT_L,
        box_size=10,
        border=4,
    )

    qr.add_data(urlText)
    qr.make(fit=True)
    
    generatedCode = qr.make_image(fill_color="black", back_color="white")

    filePath = getDesktopPath()
    filePath += f"\\{fileName}"
    
    generatedCode.save(filePath)
# end function

def getDesktopPath():
    path = os.path.join(os.path.join(os.path.abspath(path='.')))

    while(not (path.endswith('Desktop'))):
        path = path[:-1:]
    # end while 

    return path
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if