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
    closest = 999999999999999999999

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
    ts1 = [7, 5, 9, 1, 4]
    ts2 = [-273]
    ts3 = [5526]
    ts4 = [-15, -7, -9, -14, -12]
    ts5 = [-10, -10]
    ts6 = []
    ts7 = [15, -7, 9, 14, 7, 12]

    tests = [ts1, ts2, ts3, ts4, ts5, ts6, ts7]

    for i in tests:
        with redirect_stdout(sys.stderr):
            solution = compute_closest_to_zero(i)
        print(solution)
    # end for


if __name__ == "__main__":
    main()
# Ignore and do not change the code above
