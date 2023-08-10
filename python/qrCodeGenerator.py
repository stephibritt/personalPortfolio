#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 4/26/2023
#================================================================================#
import qrCodeGenerator

def main():
    print("Enter a URL in plain text to generate a QR code.")
    
    repeat = "Y"
    while repeat.upper() == "Y":
        
        
        repeat = input("\nWould you like to calculate another salary? (Y/n): ")
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to calculate another salary? (Y/n): ")
        # end while
    # end while
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if