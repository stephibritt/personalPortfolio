#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 9/25/2021
#================================================================================#

def main():
    # MAINLINE LOGIC CODE BEGINS

    print("Decimal to Base 2-16 Converter.\n")    

    number = int(input("Enter a number to convert: "))
    while number < 0:
        print("Please enter a positive whole number.")
        number = int(input("Enter a number to convert: "))
    # end while
    print()

    base = 1
    for _ in range(2, 17):
        base += 1
        print("Base " + str(base) + ": " + convertDecimalTo(number, base))
    # MAINLINE LOGIC CODE ENDS
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