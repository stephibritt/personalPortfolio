#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 3/16/2023
#================================================================================#

from math import floor

def main():
    # outline the purpose of the program and ask the user for a year to calculate, assigning that to year
    print("This program calculates what day Easter falls on for a given year.\n")
    year = int(input("What year would you like to use? "))
    
    # use the given year in the anonymous gregorian computus algorith to find the date of easter.
    a = year % 19
    b = floor(year/100)
    c = year % 100
    d = floor(b / 4)
    e = b % 4
    f = floor((b + 8) / 25)
    g = floor((b - f + 1) / 3)
    h = (19 * a + b - d - g + 15) % 30
    i = floor(c / 4)
    k = c % 4
    l = (32 + 2 * e + 2 * i - h - k) % 7
    m = floor((a + 11 * h + 22 * l) / 451)
    month = floor((h + l - 7 * m + 114) / 31)
    day = 1 + ((h + l - 7 * m + 114) % 31)

    # print the results in the desired format
    print(f"\nIn {year}, Easter falls on {month}/{day}.")
    
    # print("In ", year, ", Easter falls on ", month, "/", day, ".", sep = "")
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if