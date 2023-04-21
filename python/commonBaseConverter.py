#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 10/14/2021
#================================================================================#

def main():
    # outline the purpose of the program
    print("Decimal to Base 2-16 Converter.") 

    # set the repeat variable to 'Y' to start the program
    repeat = "Y"

    # while repeat equals 'Y'
    while repeat.upper() == "Y":
        number = int(input("\nEnter a number to convert: "))

        while number < 0:
            print("Please enter a positive whole number.")
            number = int(input("Enter a number to convert: "))
        # end while
        
        print()

        base = 1
        for _ in range(2, 17):
            base += 1
            print("Base " + str(base) + ": " + convertDecimalTo(number, base))
        # end for

        # ask if the user would like to run another calculation
        repeat = input("\nWould you like to convert another number? (Y/n): ")

        # while the user enters anything other than 'Y' or 'N'
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            # inform the user of the two options and ask for valid input
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to convert another number? (Y/n): ")
        # end while
    # end while
# end function

def convertDecimalTo(number, base):
    result = ""
    while number > 0:
        remainder = number % base
        if remainder < 10:
            remainder = str(remainder)
        elif remainder == 10:
            remainder = "A"
        elif remainder == 11:
            remainder = "B"
        elif remainder == 12:
            remainder = "C"
        elif remainder == 13:
            remainder = "D"
        elif remainder == 14:
            remainder = "E"
        else:
            remainder = "F"
        # end if

        result = remainder + result
        number = number // base
    # end while

    return result
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if