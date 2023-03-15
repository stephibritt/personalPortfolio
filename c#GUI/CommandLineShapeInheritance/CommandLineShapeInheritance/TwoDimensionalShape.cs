using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class TwoDimensionalShape : Shape {
    // class properties
    public int Dimension1 { get; set; } // end property
    public int Dimension2 { get; set; } // end property
    public abstract double Area { get; } // end property

    // class constructor
    public TwoDimensionalShape(int x, int y, int dimension1, int dimension2) :
           base(x, y){
        this.Dimension1 = dimension1;
        this.Dimension2 = dimension2;
    } // end constructor
} // end class