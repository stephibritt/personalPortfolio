#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 9/7/2021
#================================================================================#

def main():
    # output the purpose of the program to calculate a dog's age in human years.
    print("This program calculates a dog's approximate age in \"dog years\" based on human years.")

    # get user input for the human age of the dog
    humYears = float(input("\nDog's age in human years? "))

    # while the given value is less than zero
    while humYears < 0:
        # inform the user that the entered number is invalid and ask for a valid entry
        humYears = float(input("\nAge is invalid as entered. Please enter a valid age: "))
    # end while

    # perform the relative calculations based on the entered age
    if humYears <= 1:
        dogYears = humYears * 15
    elif humYears <= 2:
        dogYears = 15 + 9 * (humYears - 1)
    else:
        dogYears = 15 + 9 + 5 * (humYears - 2)
    # end if

    # output the answer to the user
    print(f"\nA dog with a human age of {humYears:.1f} years is {dogYears:.1f} in dog years.")
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if