using System;

class HeartRate {
    // Private member variable
    private DateTime m_birthDate;

    // Property BirthYear handles access to m_birthYear member variable
    public DateTime BirthYear {
        get {
            return m_birthDate;
        } // end get
        set {
            // If passed-in value is less than current year and exactly 4 characters
            if (m_birthDate.Date < DateTime.Today) {
                m_birthDate = value;
            } else {    // Otherwise, throw an exception
                throw new Exception("Birth date cannot be in the future.");
            } // end if
        } // end set
    } // end property

    // Property calculates and returns user's age based on birth date
    public int Age {
        get {
            return (int)((DateTime.Today - this.BirthYear.Date).Days / 365.25);
        } // end get        
    } // end method

    // Property calculates and returns maximum heart rate
    public int MaxHeartRate {
        get {
            return 220 - this.Age;
        } // end get        
    } // end method

    // Property calculates and returns minimum target heart rate
    public double MinTargetHeartRate {
        get {
            return this.MaxHeartRate * 0.5;
        } // end get        
    } // end method

    // Property calculates and returns maximum target heart rate
    public double MaxTargetHeartRate {
        get {
            return this.MaxHeartRate * 0.85;
        } // end get            
    } // end method

    // Constructor
    public HeartRate(DateTime birthYear) {       
        this.BirthYear = birthYear;
    } // end constructor

    public override string ToString() {
        return $"Age: {this.Age}\n" +
               $"Maximum heart rate: {this.MaxHeartRate}\n" +
               $"Minimum target heart rate: {this.MinTargetHeartRate:N0}\n" +
               $"Maximum target heart rate: {this.MaxTargetHeartRate:N0}\n\n" +
               $"Based on your age, keep your heart rate between " +
               $"{this.MinTargetHeartRate:N0} and {this.MaxTargetHeartRate:N0} while exercising.";
    } // end method
} // end class