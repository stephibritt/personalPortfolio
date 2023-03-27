#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 3/27/2023
#================================================================================#

def main():
    # output the usage and purpose of the program
    print("This program calculates the total cost of a series of items based on the Canadian payment method.\n")
    print("Enter an item's price or enter -1 to finish inputing items.\n")

    # global variables
    PENNY = .01
    NICKEL = .05
    
    # while loop to repeat the program if desired
    repeat = "Y"
    while repeat.upper() == "Y":
        # function variables
        counter = 0
        total = 0
        item = float(input(f"Item #{counter + 1}: "))

        # input validation for item value
        while item < -1 or item == 0:
            # ask for good input if the user provides erroneous values
            print("\nAn item's value can not be negative (except to exit) or zero.\n")
            item = float(input(f"Item #{counter + 1}: "))
        # end while

        while item != -1:
            counter += 1
            total += item
            item = float(input(f"Item #{counter + 1}: "))
        # end while

        # this is to determine the amount based on the canadian penny not being used for cash purchases anymore, so totals must be rounded to nickel values
        numPenny = total / PENNY
        numNickel = (total // NICKEL)
        determine = numPenny % 5

        # if the value is greater than half, round up
        if determine >= 2.5:
            numNickel += 1
            upTotal = numNickel * NICKEL

            cash = upTotal
        elif determine <= 2.5 and determine > 0:
            downTotal = numNickel * NICKEL
            
            if downTotal < NICKEL:     # This if is assuming that you can't just pay nothing for a purchase under a nickel (if there were such a thing)
                cash = NICKEL
            else:
                cash = downTotal
            # end if
        else:
            cash = total
        # end if
        
        # if no items were entered...
        if counter == 0:
            print("\nNo items input.")
        else:
            # output the total for credit/debit and cash
            print(f"\nCredit/debit: ${total:.2f}")
            print(f"Cash: ${cash:.2f}")
        # end if
        
        repeat = input("\nWould you like to input another transaction? (Y/n): ")
        print()
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to input another transaction? (Y/n): ")
            print()
        # end while
    # end while
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if