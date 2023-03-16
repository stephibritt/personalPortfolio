#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  CREATED: 10/29/2021
#================================================================================#

def main():
    print("Pig Latin Translator\n")
    print("This program translates the contents of a text file to Pig Latin.\n")

    while True:      
        try:
            # Get file path from user
            filePath = "Chapter 8\\" + input("File path: ")

            # Attempt to open and read contents of specified file and 
            # Split the text into a list based on newline character (each line of text becomes an element in list)
            linesList = readFile(filePath).split("\n")
        except Exception as ex:
            # If there is an error opening file
            print(ex)
        else:
            break       # Exit loop if there are no problems
        # end try        
    # end while

    # Translate and add each line to translated list
    translatedLinesList = []
    for line in linesList:
        translatedLinesList.append(translateLineToPigLatin(line))
    # end for

    try:
        # Determine name for translated file
        periodIndex = filePath.rfind(".")
        translatedFilePath = filePath[:periodIndex] + "PigLatin" + filePath[periodIndex:]

        # Write translation to file
        print("\nTranslating...")
        writeFile(translatedFilePath, translatedLinesList)
        print("Translated file written to", translatedFilePath)
    except Exception as ex:
        # If there is an error writing file
        print(ex)
    # end try    
# end function


def readFile(filePath):
    try:
        # Open file path for reading
        fileObject = open(filePath, "r")

        # Read all lines from file
        fileContents = fileObject.read()
    except FileNotFoundError:
        raise FileNotFoundError("Unable to open file: the specified file does not exist.")
    except:
        raise Exception("An unexpected problem occurred whilst opening the file.")
    else:
        fileObject.close()

        return fileContents
    # end try
# end function


def writeFile(filePath, linesList):
    try:
        # Open file path for writing
        fileObject = open(filePath, "w")

        # Ensure there is at least 1 item in list
        if len(linesList) > 0:
            # Process each line of text in list
            for line in linesList:
                # Write each translated line to file
                fileObject.write(line)
            # end for
        else:
            raise Exception("Unable to translate: the file does not contain any text.")
        # end if
    except:
        raise Exception("An unexpected problem occurred whilst writing the file.")
    else:
        fileObject.close()
    # end try
# end function


def translateLineToPigLatin(line):
    translatedLine = ""
    
    # If line has one or more character
    if len(line) > 0:
        # If line ends with a newline character, remove it
        if line.endswith("\n"):
            line = line.rstrip("\n")
        # end if
        
        # Split line into a words list based on a space
        wordList = line.split(" ")

        # Concatenate each translated word with a trailing space to translatedLine
        for word in wordList:
            translatedLine += translateWordToPigLatin(word) + " "
        # end for
    # end if

    return translatedLine + "\n"    # Return translated line with trailing newline character
# end function


def translateWordToPigLatin(word):
    translatedWord = ""
    
    if word[0].isupper():
        if len(word) > 0:
            if word.isdigit():
                return word
            # end if

            if word[-1] in ".,:;?!":
                punctuation = word[-1]
                word = word[0:-1]
            else:
                punctuation = ""
            # end if          
            
            if word[0].lower() in "aeiou":
                translatedWord = word + "yay" + punctuation
            else:
                translatedWord = word[1].upper() + word[2:] + word[0].lower() + "ay" + punctuation
            # end if
        # end if
    else:
        if len(word) > 0:
            if word.isdigit():
                return word
            # end if

            if word[-1] in ".,:;?!":
                punctuation = word[-1]
                word = word[0:-1]
            else:
                punctuation = ""
            # end if          
            
            if word[0].lower() in "aeiou":
                translatedWord = word + "yay" + punctuation
            else:
                translatedWord = word[1] + word[2:] + word[0] + "ay" + punctuation
            # end if
        # end if
    
    return translatedWord		
# end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if