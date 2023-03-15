using System;

class Primes {
    public bool IsPrime(long number) {
        int index = 2;

        if (number < index) {
            return false;
        } else {
            while (index < number) {
                if (number % index == 0) {
                    return false;
                } // end if
                index++;
            } // end while

            return true;
        } // end if
    } // end method

    public string GetPrimes(int numberOfPrimes) {
        int primesCounter = 0;
        string output = "";
        int number = 0;

        while (primesCounter < numberOfPrimes) {
            if (IsPrime(number) == true) {
                if (primesCounter == 0) {
                    primesCounter++;
                    output += $"{number}";
                } else {
                    primesCounter++;
                    output += $", {number}";
                } // end if                
            } // end if

            number++;
        } // end while

        return output;
    } // end method
} // end class