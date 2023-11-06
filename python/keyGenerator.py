#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 11/6/2023
#================================================================================#

import os
from time import sleep
from random import randint as rnd

def main():
    repeat = "Y"
    while repeat.upper() == "Y":
        print("Generating 30 random keys:\n")
        
        example = "xxxyy-OEM-nnnnnnn-zzzzz\n"
        print(f"Ex: {example.upper()}")

        print(generatenNnnnnnn())

        # for i in range(1, 31):
        #     print(f"{i:2}: {generateKey()}")
        # # end for
        
        # print("\nDone")

        repeat = input("\nWould you like to generate another key? (Y/n): ")
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to generate another key? (Y/n): ")
        # end while
    # end while
# end function

def generateKey():
    # example output xxxyy-OEM-nnnnnnn-zzzzz
    # xxx must be a number in range 001 and 366
    # yy is last 2 digits of a number in range 095 and 103
    # OEM must remain as is
    # the nnnnnnn must always start with 2 zeros, the rest can be anything as long as the summ 
    # is divisible by 7 with no remainder
    # the zzzzz can be any set of numbers

    xxx = generateXxx()
    yy = generateYy()
    nnnnnnn = "nnnnnnn"
    zzzzz = generateZzzzz()
    string = f"{xxx}{yy}-OEM-{nnnnnnn}-{zzzzz}"
    
    return string.upper()
# end function

def generateXxx():
    # xxx must be a number in range 001 and 366
    xxx = str(rnd(1, 366))

    while len(xxx) < 3:
        zero = "0"
        xxx = zero + xxx
    # end while
    
    return xxx
# end function

def generateYy():
    # yy is last 2 digits of a number in range 095 and 103
    yy = str(rnd(95, 103))

    while len(yy) < 2:
        zero = "0"
        yy = zero + yy
    # end while

    while len(yy) > 2:
        yy = yy[1::]
    # end while
    
    return yy
# end function

def generatenNnnnnnn():
    # the nnnnnnn must always start with 2 zeros, the rest can be anything as long as the summ 
    # is divisible by 7 with no remainder
    n0 = "00"
    nInt = str(rnd(0, 99999))

    sum = 0
    for i in nInt:
        sum += int(i)
    # end for

    remTest = sum % 7

    # while remTest != 0:
    #     nInt = int(nInt) - 1
    # # end while

    nnnnnnn = n0 + nInt

    while len(nnnnnnn) < 7:
        zero = "0"
        nnnnnnn = zero + nnnnnnn
    # end while

    return f"{sum}, {nnnnnnn}, {remTest}"
# end function

def generateZzzzz():
    # the zzzzz can be any set of numbers
    zzzzz = str(rnd(0, 99999))
    
    while len(zzzzz) < 5:
        zero = "0"
        zzzzz = zero + zzzzz
    # end while
    
    return zzzzz
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if