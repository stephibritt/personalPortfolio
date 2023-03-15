using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Square : TwoDimensionalShape {
    // class properties
    public int Side {
        get {
            return base.Dimension1;
        } // end get

        set {
            base.Dimension1 = value;
            base.Dimension2 = value;
        } // end set
    } // end property

    public override double Area {
        get {
            return this.Side * this.Side;
        } // end get
    } // end property

    public override string Name {
        get {
            return "Square";
        } // end get
    } // end property

    // class constructor
    public Square(int x, int y, int side) : 
           base(x, y, side, side) {
        this.Side = side;
    } // end constructor

    // class method
    public override string ToString() {
        return $"{base.ToString()}\n" +
               $"Side: {this.Side}\n";
    } // end method
} // end class