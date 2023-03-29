using System;

class Card {
    // auto-implemented get-only properties
    public string Face { get; }
    public string Color { get; }
    public string Suit { get; }
    public int Value { get; }

    // constructor method
    public Card(string face, string color, string suit, int value) {
        this.Face = face;
        this.Color = color;
        this.Suit = suit;
        this.Value = value;
    } // end constructor

    // methods
    public  string ToLongString() {
        return $"{Face} of {Color} {Suit} ({Value})";
    } // end method

    public override string ToString() {
        return $"{Face} of {Suit}";
    } // end method
} // end class