namespace ColorSpheres;

class Sphere
{
    private Color color;
    private double radius;
    private int timesThrown;

    public Sphere(Color color, double radius)
    {
        this.color = color;
        this.radius = Math.Max(0, radius);
        this.timesThrown = 0;
    }

    public void Pop() => radius = 0;

    public void Throw()
    {
        if (radius > 0)
            timesThrown++;
    }

    public int GetTimesThrown() => timesThrown;

    public override string ToString() =>
        $"Sphere - Color: {color}, Radius: {radius}, Thrown: {timesThrown} times";
}
