using System;
using System.Drawing;
using System.Windows.Forms;

public class Easter {
    // member variables
    private double m_year;
    private double m_month;
    private double m_day;

    // properties
    public double Year {
        get {
            return m_year;
        } // end get

        set {
            if (value > 0) {
                m_year = value;
            } else {
                throw new ArgumentOutOfRangeException("Year must be greater than zero.");
            } // end if
        } // end set
    } // end property

    // default constructor
    public Easter() {
        this.Year = DateTime.Now.Year;
        this.CalculateEaster(Year);
    } // end constructor

    // one-argument constructor
    public Easter(double year) {
        this.Year = year;
        this.CalculateEaster(Year);
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

        m_month = Math.Floor((h + l - 7 * m + 114) / 31);
        m_day = 1 + ((h + l - 7 * m + 114) % 31);
    } // end method

    public override string ToString() {
        if (m_month == 3) {
            return $"In {Year}, Easter falls on March {m_day}.";
        } else if (m_month == 4) {
            return $"In {Year}, Easter falls on April {m_day}.";
        } else {
            return "An unknown error has occurred.";
        } // end if
    } // end method
} // end class