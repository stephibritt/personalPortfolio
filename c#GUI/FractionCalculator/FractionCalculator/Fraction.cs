using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator {
    internal class Fraction {
        // member variables
        private int m_numerator;
        private int m_denominator;

        // class properties
        public int Numerator {
            get { 
                return m_numerator; 
            } // end get

            set { 
                m_numerator = value;
            } // end set
        } // end property

        public int Denominator {
            get {
                return m_denominator;
            } // end get

            set {
                if (value == 0) {
                    throw new DivideByZeroException();
                } else {
                    m_denominator = value;
                } // end if
            } // end set
        } // end property

        // class constructor with defaults
        public Fraction(int numerator = 1, int denominator = 1) {
            // ensure negative and positive rules apply
            if (numerator < 0 && denominator < 0) { // this ensures the negatives cancel properly
                numerator *= -1;
                denominator *= -1;
            } else if (numerator > 0 && denominator < 0) { // this ensures that negative denominators are not possible,
                numerator *= -1;                           //but the fractoin remains negative
                denominator *= -1;
            } // end if

            this.Numerator = numerator;
            this.Denominator = denominator;

            this.Reduce(); // reduce the fraction as soon as it is created
        } // end constructor

        // copy constructor
        public Fraction(Fraction fraction) :
            this(fraction.Numerator, fraction.Denominator) { }

        // overload methods
        public static Fraction operator +(Fraction x, Fraction y) {
            if (x.Denominator != y.Denominator) {
                x.Numerator *= y.Denominator;
                y.Numerator *= x.Denominator;
                x.Denominator *= y.Denominator;
                y.Denominator = x.Denominator;
            } // end if

            return new Fraction(x.Numerator + y.Numerator, x.Denominator);
        } // end method

        public static Fraction operator -(Fraction x, Fraction y) {
            if (x.Denominator != y.Denominator) {
                x.Numerator *= y.Denominator;
                y.Numerator *= x.Denominator;
                x.Denominator *= y.Denominator;
                y.Denominator = x.Denominator;
            } // end if

            return new Fraction(x.Numerator - y.Numerator, x.Denominator);
        } // end method

        public static Fraction operator *(Fraction x, Fraction y) {
            return new Fraction(x.Numerator * y.Numerator, x.Denominator * y.Denominator);
        } // end method

        public static Fraction operator /(Fraction x, Fraction y) {
            return new Fraction(x.Numerator * y.Denominator, x.Denominator * y.Numerator);
        } // end method

        private void Reduce() {
            int testNumerator;
            int commonDenominator = 1;

            // make sure you test with positive numbers to find the common denominator
            if (Numerator < 0) {
                testNumerator = this.Numerator * -1;
            } else {
                testNumerator = this.Numerator;
            } // end if

            //find common denominator
            if (testNumerator > this.Denominator) {
                for (int i = 2; i <= this.Denominator; i++) {
                    if ((testNumerator % i) == 0 && (this.Denominator % i) == 0) {
                        commonDenominator = i;
                    } // end if
                } // end for
            } else {
                for (int i = 2; i <= testNumerator; i++) {
                    if ((testNumerator % i) == 0 && (this.Denominator % i) == 0) {
                        commonDenominator = i;
                    } // end if
                } // end for
            } // end if

            // simplify by dividing by common denominator
            this.Numerator /= commonDenominator;
            this.Denominator /= commonDenominator;
        } // end method

        public override string ToString() {
            if (this.Numerator == 0) {
                return "0";
            } else if (this.Denominator == 1){ 
                return $"{this.Numerator}";
            } else if (this.Numerator == this.Denominator) {
                return "1";
            } else if (this.Numerator > this.Denominator) {
                return $"{this.Numerator}/{this.Denominator} or" +
                    $"\n{this.Numerator / this.Denominator} {this.Numerator % this.Denominator}/{this.Denominator}";
            } else {
                return $"{this.Numerator}/{this.Denominator}";
            } // end if
        } // end method

        public string ToDoubleString(int precision = 3) {
            return $"{Math.Round(this.Numerator / (double)this.Denominator, precision)}";
        } // end method
    } // end class
} // end namespace