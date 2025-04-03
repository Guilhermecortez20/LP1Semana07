namespace ColorSpheres;

class Color
{
    private int red, green, blue, alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        this.red = Clamp(red);
        this.green = Clamp(green);
        this.blue = Clamp(blue);
        this.alpha = Clamp(alpha);
    }

    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    private int Clamp(int value) => Math.Clamp(value, 0, 255);

    public int GetRed() => red;
    public int GetGreen() => green;
    public int GetBlue() => blue;
    public int GetAlpha() => alpha;

    public int GetGrey() => (red + green + blue) / 3;

    public override string ToString() =>
        $"RGBA({red}, {green}, {blue}, {alpha}) - Grey: {GetGrey()}";
}

