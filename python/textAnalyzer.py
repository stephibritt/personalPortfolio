#!/c/Users/steph/AppData/Local/Programs/Python/Python311/python.exe
# the location of the python.exe

#================================================================================#
#  AUTHOR: Stephen Britt
#  E-MAIL: sdbritt@senators.ws.edu
#  EDITED: 10/14/2021
#================================================================================#

from os import readlink

from tkinter import filedialog

def main():
    print("Text File Analyzer\n")
    
    while True:
        try:
            fileName = filedialog.askopenfilename()
            
            print()

            fileObj = open(fileName, "r")
            
            text = fileObj.read().lower()

            fileObj.close()

            break
        except FileNotFoundError:
            print("The specified file could not be found.")
        except:
            print("An unknown error occurred.")
        # end try
    # end while

    sentences = (text.count(".") + text.count("!") + text.count("?"))
    
    for character in text:
        if character in ",.?/'\":;\\!@#$%^&*()_+=":
            text = text.replace(character, "")
        elif character in "\n":
            text = text.replace(character, " ")
        # end if
    # end for

    text = text.replace(" - ", " ")

    ListWithDuplicates = text.split()

    ListWithDuplicates.sort()

    uniqueWordList = list(sorted(set(ListWithDuplicates)))


    totalWords = int(len(ListWithDuplicates))
    totalUniqueWords = int(len(uniqueWordList))
    
    myDict = {}
    for index in ListWithDuplicates:
        myDict[index] = ListWithDuplicates.count(index)
    # end for

    sortedDict = sortDictionary(myDict)

    print(f"Number of sentence: {sentences}")
    print(f"Number of unique words: {totalUniqueWords}")
    print(f"Total number of words: {totalWords}\n")

    print("Word\t\tCount")
    print("____\t\t_____")

    for word in sortedDict:
        if len(word) < 8:
            print(f"{word.capitalize()}\t\t{sortedDict[word]}")
        else:
            print(f"{word.capitalize()}\t{sortedDict[word]}")
        # end if
    # end for
# end function

def sortDictionary(dictionaryObject):
    return dict(sorted(dictionaryObject.items(), reverse = True, key = lambda kv:kv[1]))
#end function

# DO NOT MODIFY CODE BELOW THIS LINE
if __name__ == "__main__":
    main()
# end if