import sys
import math
from contextlib import redirect_stdout

def sort_packages(width, height, length, mass):
    # if volume is greater than 1,000,000 cm³ or any dimension bigger than or eaqual to 150 cm: Bulky return SPECIAL
    # if heavier than or equal to 20 kg: Heavy return SPECIAL
    # if heavy and bulky: Rejected
    # Otherwise: return STANDARD
    packageType = "UNTESTED"

    volume = width * length * height

    if volume >= 1000000:
        packageType = "SPECIAL"
    # end if

    if width >= 150:
        packageType = "SPECIAL"
    elif height >= 150:
        packageType = "SPECIAL"
    elif length >= 150:
        packageType = "SPECIAL"
    # end if
        
    if mass >= 20:
        if packageType == "SPECIAL":
            packageType = "REJECTED"
        else:
            packageType = "SPECIAL"
        # end if
    # end if
    
    if packageType == "UNTESTED":
        packageType = "STANDARD"
    # end if

    return packageType
# end func




# Ignore and do not change the code below
def main():
    # pylint: disable = C, W
    # width, height, length, mass
    ts1 = [140, 140, 140, 15] # SPECIAL
    ts2 = [140, 150, 140, 15] # SPECIAL
    ts3 = [70, 30, 60, 20] # SPECIAL
    ts4 = [70, 140, 60, 20] # REJECTED
    ts5 = [70, 150, 60, 20] # STANDARD
    ts6 = [70, 140, 60, 15] # STANDARD
    ts7 = [70, 30, 60, 15] # STANDARD

    tests = [ts1, ts2, ts3, ts4, ts5, ts6, ts7]
    
    for i in tests:
        solution = "Did not check"

        with redirect_stdout(sys.stderr):
            solution = sort_packages(i[0], i[1], i[2], i[3])
        print(solution)
    # end for


if __name__ == "__main__":
    main()
# Ignore and do not change the code above
