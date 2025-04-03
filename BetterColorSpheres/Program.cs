using System;
using BetterColorSpheres;

class Program
{
    static void Main()
    {
        Color redColor = new Color(255, 0, 0);
        Color blueColor = new Color(0, 0, 255, 128);
        Color greenColor = new Color(0, 255, 0);

        Sphere redSphere = new Sphere(redColor, 5.0);
        Sphere blueSphere = new Sphere(blueColor, 3.0);
        Sphere greenSphere = new Sphere(greenColor, 7.0);

        redSphere.Throw();
        redSphere.Throw();
        blueSphere.Throw();
        greenSphere.Throw();
        greenSphere.Pop();
        greenSphere.Throw(); // Não deve contar, pois foi furada

        Console.WriteLine(redSphere);
        Console.WriteLine(blueSphere);
        Console.WriteLine(greenSphere);
    }
}

