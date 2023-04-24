using System;

//Edited by: Stephen Britt
//     date: 2/02/2022

class HeartRate {

    // member variables
    private string m_name;
    private int m_birthYear;

    // name property
    public string Name {
        get {
            return m_name;
        } // end get

        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new Exception("A name requires one or more characters.");
            } else {
                m_name = value;
            } // end if
        } // end set
    } // end property

    // birth year property
    public int BirthYear {
        get {
            return m_birthYear;
        } // end get
        set {
            if (value < (DateTime.Now.Year - 125) || value > DateTime.Now.Year - 1) {
                throw new Exception($"Invalid birth year. Year must be between {DateTime.Now.Year - 125} and {DateTime.Now.Year - 1}.");
            } else {
                m_birthYear = value;
            } // end if
        } // end set
    } // end property

    // public methods
    public HeartRate(string name, int birthYear) {
        this.Name = name;
        this.BirthYear = birthYear; 
    } // end constructor

    public int GetAge() {
        return DateTime.Now.Year - BirthYear;
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
        return $"\nHeart rate information for {Name}:" +
               $"\n    Age:                       {GetAge()} years old" +
               $"\n    Maximum heart rate:        {GetMaxHeartRate():f1} beats/minute" +
               $"\n    Minimum target heart rate: {GetMinTargetHeartRate():f1} beats/minute" +
               $"\n    Maximum target heart rate: {GetMaxTargetHeartRate():f1} beats/minute";
    } // end method
} // end class