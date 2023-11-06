import sys
import math
from contextlib import redirect_stdout

def compute_closest_to_zero(ts):
    n = len(ts)
    ts.sort()

    if n < 1:
        return 0
    elif n > 10000:
        return 0
    # end if
    
    pairs = []
    closest = 9999999

    for i in ts:
        diff = abs(i)

        if diff < closest:
            closest = diff
            pairs = [diff, i]
        elif diff == closest:
            pairs.extend([diff, i])
        # end if
    # end for
    
    tsClosestIndex = ts.index(pairs[-1])
    return ts[tsClosestIndex]
# end func




# Ignore and do not change the code below
def main():
    # pylint: disable = C, W
    ts1 = [-10, -10]
    ts2 = [-275]
    ts3 = [-15, -9, -8, -7, -2]
    ts4 = [7, 5, 9, 1, 4]
    ts5 = [7, 5, 9, -1, 4, 1]
    with redirect_stdout(sys.stderr):
        solution = compute_closest_to_zero(ts3)
    print(solution)


if __name__ == "__main__":
    main()
# Ignore and do not change the code above
