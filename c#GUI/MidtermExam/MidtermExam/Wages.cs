using System;

public class Wages {
    // class member variables
    private decimal m_hourlyPay;
    private const decimal DEFAULT_WAGE = 7.25M;
    private const decimal SALARIED_HOURS = 38.5M;
    private const decimal WEEKS_IN_YEAR = 52M;
    private const decimal MONTHS_IN_YEAR = 12M;

    // class properties
    public decimal HourlyPay {
        get {
            return m_hourlyPay;
        } // end get

        set {
            if (value <= 0) {
                throw new ArgumentOutOfRangeException("Hourly pay must be greater than zero.");
            } else {
                m_hourlyPay = value;
            } // end if
        } // end set
    } // end property

    // class constructor with default value
    public Wages(decimal hourlyPay = DEFAULT_WAGE) {
        this.HourlyPay = hourlyPay;
    } // end constructor

    // class methods
    public decimal GetWeeklyPay() {
        return this.HourlyPay * SALARIED_HOURS;
    } // end method

    public decimal GetMonthlyPay() {
        return GetYearlyPay() / MONTHS_IN_YEAR;
    } // end method

    public decimal GetYearlyPay() {
        return GetWeeklyPay() * WEEKS_IN_YEAR;
    } // end method
} // end class