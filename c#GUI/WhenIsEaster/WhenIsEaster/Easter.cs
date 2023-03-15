using System;

public class Easter {
    // member variables
    private double _year;
    private double _month;
    private double _day;

    // properties
    public double Year { 
        set {
            if (value > 0) {
                _year = value;
            } else {
                throw new ArgumentOutOfRangeException("Year must be greater than zero.");
            } // end if
        } // end set
    } // end property

    // default constructor
    public Easter() {
        this.Year = DateTime.Now.Year;
    } // end constructor

    // one-argument constructor
    public Easter(double year) {
        this.Year = year;
        this.CalculateEaster(_year);
    } // end constructor

    // calculate easter
    private void CalculateEaster(double year) {
        double a = year % 19;
        double b = Math.Floor(year / 100);
        double c = year % 100;
        double d = Math.Floor(b / 4);
        double echo = b % 4;
        double f = Math.Floor((b + 8) / 25);
        double g = Math.Floor((b - f + 1) / 3);
        double h = (19 * a + b - d - g + 15) % 30;
        double i = Math.Floor(c / 4);
        double k = c % 4;
        double l = (32 + 2 * echo + 2 * i - h - k) % 7;
        double m = Math.Floor((a + 11 * h + 22 * l) / 451);

        _month = Math.Floor((h + l - 7 * m + 114) / 31);
        _day = 1 + ((h + l - 7 * m + 114) % 31);
    } // end method

    public override string ToString() {
        return $"In {_year}, Easter falls on March {_day}.";
    } // end method
} // end class