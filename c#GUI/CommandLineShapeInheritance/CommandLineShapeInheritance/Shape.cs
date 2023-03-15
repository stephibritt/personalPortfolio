using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape {
    // class properties
    public int X { get; set; } // end property

    public int Y { get; set; } // end property

    public abstract string Name { get; } // end property

    // class constructor
    public Shape(int x, int y) {
        this.X = x;
        this.Y = y;
    } // end constructor

    // class methods
    public override string ToString() {
        return $"Name: {this.Name}\n" +
               $"X: {this.X}\n" +
               $"Y: {this.Y}";
    } // end method
} // end class