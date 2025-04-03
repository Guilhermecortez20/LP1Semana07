namespace BetterColorSpheres;

class Color
{
    private const int MinValue = 0;
    private const int MaxValue = 255;

    public int Red { get; }
    public int Green { get; }
    public int Blue { get; }
    public int Alpha { get; }

    public Color(int red, int green, int blue, int alpha)
    {
        Red = Clamp(red);
        Green = Clamp(green);
        Blue = Clamp(blue);
        Alpha = Clamp(alpha);
    }

    public Color(int red, int green, int blue) : this(red, green, blue, MaxValue) { }

    private int Clamp(int value) => Math.Clamp(value, MinValue, MaxValue);

    public int Grey => (Red + Green + Blue) / 3;

    public override string ToString() =>
        $"RGBA({Red}, {Green}, {Blue}, {Alpha}) - Grey: {Grey}";
}
