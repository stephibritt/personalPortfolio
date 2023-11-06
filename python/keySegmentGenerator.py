#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 11/6/2023
#================================================================================#

import os
from random import randint as rnd

def main():
    f = open("possible NNNNNNN values.txt", "w")
    
    # the nnnnnnn must always start with 2 zeros, the rest can be anything as long as the sum
    # # is divisible by 7 with no remainder

    n0 = "00"

    x = 0
    y = 1000
    while y <= 100000:

        for i in range(x, y):
            nInt = str(i)

            sum = 0
            for i in nInt:
                sum += int(i)
            # end for

            remTest = sum % 7

            nnnnnnn = n0 + nInt

            while len(nnnnnnn) < 7:
                zero = "0"
                nnnnnnn = zero + nnnnnnn
            # end while

            if remTest == 0:
                f.write(f"{nnnnnnn}\n")
            # end if
        # end for

        x += 1000
        y += 1000
    # end while
    
    f.close()

    print("Done!")
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if