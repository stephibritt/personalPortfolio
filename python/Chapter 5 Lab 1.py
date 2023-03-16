#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 9/25/2021
#================================================================================#

def main():
    # MAINLINE LOGIC CODE BEGINS

    print("This program calculates a dog's approximate age in \"dog years\" based on human years.")
    repeat = "Y"
    while repeat.upper() == "Y":
        print()
        humYears = float(input("Dog's age in human years? "))
        if humYears < 0:
            print("\nTo calculate a dog's age in human years, please enter a value of zero or greater.")
        else:
            dogYears = calculateDogYears(humYears)
            print("\nA dog with a human age of", format(humYears, ".1f"), "years is", format(dogYears, ".1f"), "in dog years.")
        # end if

        repeat = input("\nWould you like to calculate another dog's age? (Y/n): ")
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to calculate another dog's age? (Y/n): ")
        # end while
    # end while

    # MAINLINE LOGIC CODE ENDS
# end function

def calculateDogYears(humYears):
    if humYears <= 1:
        dogYears = humYears * 15
    elif humYears <= 2:
        dogYears = 15 + 9 * (humYears - 1)
    else:
        dogYears = 15 + 9 + 5 * (humYears - 2)
    # end if

    return dogYears
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if