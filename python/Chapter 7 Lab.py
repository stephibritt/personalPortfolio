#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 10/26/2021
#================================================================================#

from random import randrange


def main():
    
    print("This program generates a series of public IP addresses and writes them to a file.\n")
    
    while True:
        try:
            networks = int(input("How many addresses to write? "))
            while networks < 1:
                print("The number of addresses to generate must be a positive whole number.")
                networks = int(input("How many addresses to write? "))
            else:
                break
        except ValueError:
            print("The number of addresses to generate must be a positive whole number.")
        except:
            print("An unknown error has occurred.")
        # end try
    # end while
    print() 

    FILE_NAME = "Chapter 7\\ipList.txt" 
    ipList = []

    count = 0
    for _ in range(networks):
        count += 1
        ipList.append(getIpAddress())
        print(f"Address {count}: {ipList[(count - 1)]}")
    # end for

    writeFile(FILE_NAME, ipList)

    print("\nWriting addresses to file...")
    print("Done!")
# end function

def writeFile(fileName, ipList):
    try:
        fileObj = open(fileName, "w")

        for item in ipList:
            fileObj.write(item + "\n")
        # end for

        fileObj.close()
    except NameError:
        print("An error has occurred while opening the file.")
    except:
        print("An unknown error has occurred.")
# end function

def getIpAddress():
    import random
    while True:
        while True:
            octet1 = random.randint(1, 223)
            if octet1 == 10 or octet1 == 127:
                continue
            else:
                break
            # end if
        # end while


        while True:
            octet2 = random.randint(0, 255)
            if octet1 == 100 and octet2 >= 64 and octet2 <= 127:
                    continue
            elif octet1 == 169 and octet2 == 254:
                    continue
            elif octet1 == 172 and octet2 >= 16 and octet2 <= 31:
                    continue
            elif octet1 == 192 and octet2 == 168:
                continue
            elif octet1 == 198 and octet2 >= 18 and octet2 <= 19:
                continue
            else:
                break
            # end if
        # end while

        while True:
            octet3 = random.randint(0, 255)
            if octet1 == 192 and octet2 == 0 and octet3 == 0:
                continue
            elif octet1 == 192 and octet2 == 0 and octet3 == 2:
                continue
            elif octet1 == 192 and octet2 == 88 and octet3 == 99:
                continue
            elif octet1 == 198 and octet2 == 51 and octet3 == 100:
                continue
            elif octet1 == 203 and octet2 == 0 and octet3 == 113:
                continue
            else:
                break
            # end if
        # end while

        octet4 = random.randint(0, 255)

        return f"{octet1}.{octet2}.{octet3}.{octet4}"
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if