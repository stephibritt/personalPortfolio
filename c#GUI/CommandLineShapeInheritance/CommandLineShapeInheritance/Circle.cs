using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle : TwoDimensionalShape {
    // class properties
    public int Radius {
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
            return Math.PI * (this.Radius * this.Radius);
        } // end get
    } // end property

    public override string Name {
        get {
            return "Circle";
        } // end get
    } // end property

    // class constructor
    public Circle(int x, int y, int radius) :
           base(x, y, radius, radius) {
        this.Radius = radius;
    } // end constructor

    // class method
    public override string ToString() {
        return $"{base.ToString()}\n" +
               $"Radius: {this.Radius}\n";
    } // end method
} // end class