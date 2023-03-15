using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sphere : ThreeDimensionalShape {
    // class member variables

    // The formula for area of a sphere is 4 * pi * r squared. This is taking the formula for area of a circle (pi * r squared)and
    // accounting for the depth (an additional diameter = 2 * r). So the formula looks like this: (2 * r * 2 * r * pi) or (4 * pi *
    // r squared) after factoring it out.
    private const int DOUBLE_DIAMETER = 4;

    // The formula for volume of a sphere is calculated using the formula for volume of a pyramid (1 / 3 * a (area of the base) * h
    // (height, where the height extends to the center of the sphere so this is also radius) multiplied by n (the number of pyramids
    // needed), this looks like: (1 / 3 * n * a * r) or (1 / 3 * 4 * pi * r squared * r) because the area of a given sphere is 4 * pi
    // * r squared. Factoring this out returns (4 / 3 * pi * r cubed). 
    private const double ONE_THIRD_DOUBLE_DIAMETER = 4 / 3.0;
    // class properties
    public int Radius {
        get {
            return base.Dimension1;
        } // end get

        set {
            base.Dimension1 = value;
            base.Dimension2 = value;
            base.Dimension3 = value;
        } // end set
    } // end property

    public override double Area {
        get {
            return DOUBLE_DIAMETER * Math.PI * (this.Radius * this.Radius);
        } // end get
    } // end property

    public override double Volume {
        get {
            return ONE_THIRD_DOUBLE_DIAMETER * (Math.PI) * (this.Radius * this.Radius * this.Radius);
        } // end get
    } // end property

    public override string Name {
        get {
            return "Sphere";
        } // end get
    } // end property

    // class constructor
    public Sphere(int x, int y, int radius) :
           base(x, y, radius, radius, radius) {
        this.Radius = radius;
    } // end constructor

    // class method
    public override string ToString() {
        return $"{base.ToString()}\n" +
               $"Radius: {this.Radius}\n";
    } // end method
} // end class