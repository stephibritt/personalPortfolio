#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 4/26/2023
#================================================================================#
from locale import currency

def main():
    print("Please note: these calculations are based on a 40 hour work week paid in USD.")

    repeat = "Y"
    while repeat.upper() == "Y":
        print("\nChoose an operation:")
        print("1: Calculate an hourly rate from an annual salary")
        print("2: Calculate an annual salary from an hourly rate")
        print("3: Exit")
        
        operationChoice = input("\nUser choice: ")

        while not (operationChoice == "1" or operationChoice == "2" or operationChoice == "3"):
            # inform the user that the entered number is invalid and ask for a valid entry
            operationChoice = input("\nA choice must be either 1, 2, or 3: ")
        # end while
        
        if operationChoice == "1":
            while True:
                try:
                    # get user input for the human age of the dog
                    annualSalary = float(input("\nEnter an annual salary: "))

                    # while the given value is less than zero
                    while annualSalary < 0:
                        # inform the user that the entered number is invalid and ask for a valid entry
                        annualSalary = int(input("\nAn annual salary cannot be negative: "))
                    # end while

                    break
                except:
                    print("\nA choice must be a valid number.")
                # end try
            # end while
            
            print(f"\nAn annual salary of ${'{:,.2f}'.format(annualSalary)} equals an hourly rate of ${CalculateHourlyRate(annualSalary)}")
        elif operationChoice == "2":
            while True:
                try:
                    # get user input for the human age of the dog
                    hourlyRate = float(input("\nEnter an hourly rate: "))

                    # while the given value is less than zero
                    while hourlyRate < 0:
                        # inform the user that the entered number is invalid and ask for a valid entry
                        hourlyRate = int(input("\nAn hourly rate cannot be negative: "))
                    # end while

                    break
                except:
                    print("\nA choice must be a valid number.")
                # end try
            # end while
            
            print(f"\nAn hourly rate of ${'{:,.2f}'.format(hourlyRate)} equals an annual salary of ${CalculateAnnualSalary(hourlyRate)}")
        else:
            exit()
        # end if

        repeat = input("\nWould you like to calculate another salary? (Y/n): ")
        while not (repeat.upper() == "Y" or repeat.upper() == "N"):
            print("\nPlease enter 'Y' to continue or 'N' to quit.")
            repeat = input("\nWould you like to calculate another salary? (Y/n): ")
        # end while
    # end while
# end function

def CalculateHourlyRate(annualSalary):
    monthlyRate = annualSalary / 12
    weeklyRate = monthlyRate / 4
    hourlyRate = weeklyRate / 40
    
    hourlyRate = '{:,.2f}'.format(hourlyRate)

    return hourlyRate
# end function

def CalculateAnnualSalary(hourlyRate):
    weeklyRate = hourlyRate * 40
    monthlyRate = weeklyRate * 4
    annualSalary = monthlyRate * 12
    
    annualSalary = '{:,.2f}'.format(annualSalary)

    return annualSalary
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if