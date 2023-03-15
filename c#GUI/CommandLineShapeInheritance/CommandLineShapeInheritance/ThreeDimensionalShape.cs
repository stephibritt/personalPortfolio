using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class ThreeDimensionalShape : Shape {
    // class properties
    public int Dimension1 { get; set; } // end property
    public int Dimension2 { get; set; } // end property
    public int Dimension3 { get; set; } // end property
    public abstract double Area { get; } // end property
    public abstract double Volume { get; } // end property

    // class constructor
    public ThreeDimensionalShape(int x, int y, int dimension1, int dimension2, int dimension3) :
           base(x, y) {
        this.Dimension1 = dimension1;
        this.Dimension2 = dimension2;
        this.Dimension3 = dimension3;
    } // end constructor
} // end class