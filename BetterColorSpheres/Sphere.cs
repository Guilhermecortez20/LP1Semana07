namespace BetterColorSpheres;

class Sphere
{
    public Color Color { get; }
    public double Radius { get; private set; }
    public int TimesThrown { get; private set; }

    public Sphere(Color color, double radius)
    {
        Color = color;
        Radius = Math.Max(0, radius);
        TimesThrown = 0;
    }

    public void Pop() => Radius = 0;

    public void Throw()
    {
        if (Radius > 0)
            TimesThrown++;
    }

    public override string ToString() =>
        $"Sphere - Color: {Color}, Radius: {Radius}, Thrown: {TimesThrown} times";
}
