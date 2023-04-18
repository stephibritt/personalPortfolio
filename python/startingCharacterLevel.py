#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

import random as rnd

def main():
    startInt = int(input("Enter a starting integer: "))
    
    endInt = int(input("Enter a ending integer: "))

    while startInt < 1 or endInt > 20:
        print("The specified range is invalid")
        
        startInt = int(input("Enter a starting integer: "))
        endInt = int(input("Enter a ending integer: "))
    # end while

    level = rnd.randint(startInt, endInt)

    print()
    print(f"Your starting level is: {level}")
# end main

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if