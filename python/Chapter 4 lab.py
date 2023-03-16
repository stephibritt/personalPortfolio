#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 9/15/2021
#================================================================================#

def main():
    # MAINLINE LOGIC CODE BEGINS

    print("This program calculates the total cost of a series of items based on the Canadian payment method.\n")
    print("Enter an item's price or enter -1 to finish inputing items.\n")

    PENNY = .01
    NICKEL = .05
    counter = 0
    total = 0   
    repeat = "Y"
    while repeat.upper() == "Y":
        counter = 0
        total = 0
        item = float(input("Item #" + str(counter + 1) + ": "))
        while item < -1 or item == 0:
            print("\nAn item's value can not be negative (except to exit) or zero.\n")
            item = float(input("Item #" + str(counter + 1) + ": "))
        # end while

        while item != -1:
            counter += 1
            total += item
            item = float(input("Item #" + str(counter + 1) + ": "))
        # end while
        if counter == 0:
            print("\nNo items input.")
        else:
            print(f"\nCredit/debit: $ {total:.2f}")
        # end if

        numPenny = total / PENNY
        determine = numPenny % 5
        if determine >= 2.5:
            numNickel = (total // NICKEL) + 1
            upTotal = numNickel * NICKEL
            print(f"Cash: ${upTotal:.2f}")
        elif determine < 2.5 and determine > 0:
            numNickelTwo = (total // NICKEL)
            downTotal = numNickelTwo * NICKEL        
            if downTotal < NICKEL:     # This if is assuming that you can't just pay nothing for a purchase under a nickel (if there were such a thing)
                print("Cash:$" + str(NICKEL))
            else:
                print(f"Cash: ${downTotal:.2f}")
            # end if
        else:
            print(f"Cash: $ {total:.2f}")
        # end if

        repeat = input("\nWould you like to input another transaction? (Y/n): ")
        print()
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to input another transaction? (Y/n): ")
            print()
        # end while
    # end while

    # MAINLINE LOGIC CODE ENDS
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if