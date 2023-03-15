using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HeartRate {
    // member variables
    private DateTime m_birthDate;

    // birth year property
    public DateTime BirthDate {
        get {
            return m_birthDate;
        } // end get
        set {
            m_birthDate = value;
        } // end set
    } // end property

    // public methods
    public HeartRate(DateTime birthDate) {
        this.BirthDate = birthDate;
    } // end constructor

    public int GetAge() {
        // if birthday has passed
        if ((DateTime.Now.Month > BirthDate.Month) || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day >= BirthDate.Day)) {
            return DateTime.Now.Year - BirthDate.Year;
        } else { // birthday has not passed
            return (DateTime.Now.Year - BirthDate.Year) - 1;
        } // end if
    } // end method

    public int GetMaxHeartRate() {
        return 220 - GetAge();
    } // end method

    public double GetMinTargetHeartRate() {
        return GetMaxHeartRate() * .50;
    } // end method

    public double GetMaxTargetHeartRate() {
        return GetMaxHeartRate() * .85;
    } // end method

    public override string ToString() {
        return $"Age: {GetAge()} years old" +
                $"\nMaximum heart rate: {GetMaxHeartRate()} beats/minute" +
                $"\nMinimum target heart rate: {GetMinTargetHeartRate():n0} beats/minute" +
                $"\nMaximum target heart rate: {GetMaxTargetHeartRate():n0} beats/minute" +
                $"\n\nBased on your age, keep your heart rate between {GetMinTargetHeartRate():n0} " +
                $"and {GetMaxTargetHeartRate():n0} while exercising.";
    } // end method
} // end class