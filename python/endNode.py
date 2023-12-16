import sys
import math
from contextlib import redirect_stdout
from random import randint

def find_end_node(starting_node, to_ids, from_ids):
    # set starting node to a placeholder (current node)
    # fine the index of the current node
    # pop the item at the index, this will remove it and prevent loops
    # find what node resides at the same index of the from_ids array
    # make that the next node
    # if the next node is equal to the current node, end

    currentNode = starting_node
    nextNode = -999
    sentinel = True

    while sentinel:
        try:
            currentIndex = to_ids.index(currentNode)
        except:
            return currentNode
        # end try

        to_ids.pop(currentIndex)
        nextNode = from_ids.pop(currentIndex)

        if currentNode == nextNode:
            sentinel = False
        elif nextNode == starting_node:
            sentinel = False
        elif nextNode not in to_ids:
            sentinel = False
        else:
            currentNode = nextNode
        # end if
    # end while

    return currentNode
# end func




# Ignore and do not change the code below
def main():
    # pylint: disable = C, W
    starting_node = 7 #randint(1, 7)
    to_ids =   [1, 2, 3, 4, 5, 6, 7]
    from_ids = [2, 3, 4, 5, 6, 7, 0]
    
    with redirect_stdout(sys.stderr):
        solution = find_end_node(starting_node, to_ids, from_ids)
        print(solution)
    # end for


if __name__ == "__main__":
    main()
# Ignore and do not change the code above
