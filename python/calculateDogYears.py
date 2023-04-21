#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 10/14/2021
#================================================================================#

def main():
    print("This program calculates a dog's approximate age in \"dog years\" based on human years.")
    repeat = "Y"
    while repeat.upper() == "Y":
        # get user input for the human age of the dog
        humanYears = float(input("\nDog's age in human years? "))

        # while the given value is less than zero
        while humanYears < 0:
            # inform the user that the entered number is invalid and ask for a valid entry
            humanYears = float(input("\nAge is invalid as entered. Please enter a valid age: "))
        # end while

        dogYears = CalculateDogYears(humanYears)

        # output the answer to the user
        print(f"\nA dog with a human age of {humanYears:.1f} years is {dogYears:.1f} in dog years.")

        repeat = input("\nWould you like to calculate another dog's age? (Y/n): ")
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to calculate another dog's age? (Y/n): ")
        # end while
    # end while
# end function

def CalculateDogYears(humanYears):

    # perform the relative calculations based on the entered age
    if humanYears <= 1:
        dogYears = humanYears * 15
    elif humanYears <= 2:
        dogYears = 15 + 9 * (humanYears - 1)
    else:
        dogYears = 15 + 9 + 5 * (humanYears - 2)
    # end if

    return dogYears
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if