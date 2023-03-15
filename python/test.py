import random as rnd

def main():
    startInt = int(input("Enter a starting integer: "))


    endInt = int(input("Enter a ending integer: "))

    level = rnd.randint(startInt, endInt)

    while startInt < 1 or endInt > 20:
        print("The specified range is invalid")
        
        startInt = int(input("Enter a starting integer: "))
        endInt = int(input("Enter a ending integer: "))
    # end while

    print()
    print(f"Your starting level is: {level}")
# end main

main()