#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 11/15/2021
#================================================================================#

class Vehicle:
    def __init__(self, make, model, year):
        self.setMake(make)
        self.setModel(model)
        self.setYear(year)
        self.__speed = 0
    # end method

    # Mutators

    def setMake(self, make):
        if len(make) > 0:
            self.__make = make
        else:
            raise Exception("The make must be one or more characters.")
        # end if        
    # end method

    def setModel(self, model):
        if len(model) > 0:
            self.__model = model
        else:
            raise Exception("The model must be one or more characters.")
        # end if    
    # end method

    def setYear(self, year):
        if year >= 1900 and year <= 2022:
            self.__year = year
        else:
            raise Exception("The year must be between 1900 and 2022.")
        # end if
    # end method

    def accelerate(self):
        if self.__speed < 200:
            self.__speed += 5
        else:
            None
        # end if
    # end method

    def decelerate(self):
        if self.__speed >= 5:
            self.__speed -= 5
        else:
            None
        # end if
    # end method

    # Accesssors

    def getMake(self):
        return self.__make
    # end method

    def getModel(self):
        return self.__model
    # end method

    def getYear(self):
        return self.__year
    # end method

    def getSpeed(self):
        return self.__speed
    # end method

    def __str__(self):
        return (f"The {self.__year} {self.__make} {self.__model} is traveling at {self.__speed} MPH.")
    # end method
# end class

def main():
    print("Vehicle Class Test Program\n")
    
    myCarObj = Vehicle("Chevy", "Spark", 2015)

    timesToAccelerate = 5

    timesToDecelerate = 5

    print("Accelerating...")
    for _ in range(timesToAccelerate):
        myCarObj.accelerate()
        print(f"Current speed: {myCarObj.getSpeed()}")
    # end for

    print("\nBraking...")
    for _ in range(timesToDecelerate):
        myCarObj.decelerate()
        print(myCarObj)
    # end for
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if