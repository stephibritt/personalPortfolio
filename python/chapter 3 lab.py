#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 9/7/2021
#================================================================================#

def main():
    # MAINLINE LOGIC CODE BEGINS

    print("This program calculates a dog's approximate age in \"dog years\" based on human years.")
    humYears = float(input("Dog's age in human years? "))
    if humYears < 0:
        print("Age is invalid as entered. Human years must be a positive number.")
    else:
        if humYears <= 1:
            dogYears = humYears * 15
        elif humYears <= 2:
            dogYears = 15 + 9 * (humYears - 1)
        else:
            dogYears = 15 + 9 + 5 * (humYears - 2)
        print("A dog with a human age of", format(humYears, ".1f"), "years is", format(dogYears, ".1f"), "in dog years.")
        # end if
    # end if
    

    # MAINLINE LOGIC CODE ENDS
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if