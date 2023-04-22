using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edited by: Stephen Britt
//     Date: 4/21/2023

class BMI {
    // member variables
    private double m_userWeightInPounds;
    private double m_userHeightInInches;

    public double UserWeightInPounds {
        get {
            return m_userWeightInPounds;
        } // end get

        set {
            if (value > 0) {
                m_userWeightInPounds = value;
            } else {
                throw new Exception("A weight must be greater than zero.");
            } // end if
        } // end set
    } // end property

    public double UserHeightInInches {
        get {
            return m_userHeightInInches;
        } // end get

        set {
            if (value > 0) {
                m_userHeightInInches = value;
            } else {
                throw new Exception("A height must be greater than zero.");
            } // end if
        } // end set
    } // end property

    public BMI(double weightInPounds = 1, double heightInInches = 1) {
        UserWeightInPounds= weightInPounds;
        UserHeightInInches= heightInInches;
    } // end constructor

    public double GetBMIScore() {
        double bmiScore = (UserWeightInPounds * 703) / (UserHeightInInches * UserHeightInInches);
        return bmiScore;
    } // end method

    public string GetBMIValue() {
        if (GetBMIScore() < 18.5) {
            return "underweight";
        } else if (GetBMIScore() >= 18.5 && GetBMIScore() <= 24.9) {
            return "normal";
        } else if (GetBMIScore() >= 25 &&  GetBMIScore() <= 29.9) {
            return "overweight";
        } else {
            return "obese";
        } // end if
    } // end method

    public override string ToString() {
        return $"For a person of {UserWeightInPounds:f1} lbs. and " +
            $"{UserHeightInInches:f1} in. the general BMI score is {GetBMIScore():f1}.\n" +
            $"The National Institute of Health estimates this to be {GetBMIValue()}.";
    } // end method
} // end class