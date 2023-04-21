#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 10/14/2021
#================================================================================#

def main():
    print("Student Bio Web Page Generator")
    print("This program generates a web page based on entered information and saves it in the current directory.\n")

    name = input("Name: ") 
    while len(name) < 1:        
        name = input("Invalid input. Must enter one or more characters. Enter your name: ")
    # end while

    major = input("Major: ")
    while len(major) < 1:
        major = input("Invalid input. Must enter one or more characters. Enter your major: ")
    # end while

    college = input("College: ")
    while len(college) < 1:
        college = input("Invalid input. Must enter one or more characters. Enter your college: ")
    # end while

    gradYear = input("Graduation year: ")
    while len(gradYear) < 1:
        gradYear = input("Invalid input. Must enter one or more characters. Enter your expected graduation year: ")
    # end while

    bioSentence = input("Hobbies and interests: ")
    print()

    fileName = "biography.html"
    
    print("Writing web page to 'biography.html'.")
    writeBiography(fileName, name, major, college, gradYear, bioSentence)
    print("Done!")
# end function

def writeBiography(fileName, name, major, college, gradYear, bioSentence):
    try:
        fileObj = open(f"{fileName}", "w")
    
        fileObj.write("<html>\n")
        fileObj.write(f"<head><title>{college} student: {name}</title></head>\n")
        fileObj.write("<body>\n")
        fileObj.write(f"<center><h1>{name}</h1></center>\n")
        fileObj.write("<hr />\n")
        fileObj.write(f"My name is {name}. I am a {major} major at {college}. I expect to graduate in {gradYear}.\n")
        fileObj.write("<br /><br />\n")
        fileObj.write(bioSentence + "\n")
        fileObj.write("<hr />\n")
        fileObj.write("</body>\n")
        fileObj.write("</html>")

        fileObj.close()
    except:
        print("An unknown error occurred while opening or writing to the file.")
    # end try
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if