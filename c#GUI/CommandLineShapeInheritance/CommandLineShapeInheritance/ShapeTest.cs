using System;
class ShapeTest {
    static void Main() {
        // Array of Shape objects
        Shape[] shapes = new Shape[4];
        // Instanciate Shape elements as subclass objects
        shapes[0] = new Circle(22, 88, 4);
        shapes[1] = new Square(71, 96, 10);
        shapes[2] = new Sphere(8, 89, 2);
        shapes[3] = new Cube(79, 61, 8);
        // Loop through each item in the shapes array
        foreach (var thisShape in shapes) {
            // Output the current shape's name and call its ToString() method
            Console.Write($"{thisShape}");
            // If the current shape is a 2D shape...
            if (thisShape is TwoDimensionalShape) {
                // Cast the shape as a 2D shape
                TwoDimensionalShape twoDimensionalShape = (TwoDimensionalShape)thisShape;
                // Output the 2D shape's area
                Console.WriteLine($"Area: {twoDimensionalShape.Area:N2}");
                // If the current shape is a 3D shape...
            } else if (thisShape is ThreeDimensionalShape) {
                // Cast the shape as a 3D shape
                ThreeDimensionalShape threeDimensionalShape = (ThreeDimensionalShape)thisShape;
                // Output the 3D shape's area and volume
                Console.WriteLine($"Area: {threeDimensionalShape.Area:N2}");
                Console.WriteLine($"Volume: {threeDimensionalShape.Volume:N2}");
            } // end if
            Console.WriteLine(); // Blank line
        } // end foreach
    } // end method
} // end class