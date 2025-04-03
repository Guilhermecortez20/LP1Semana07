# BetterColorSpheres
Este projeto implementa as classes `Color` e `Sphere` utilizando propriedades.

## UML Diagram

```mermaid
classDiagram
    class Color {
        +int Red
        +int Green
        +int Blue
        +int Alpha
        +int Grey
        -int Clamp(int) 
        +Color(int red, int green, int blue, int alpha)
        +Color(int red, int green, int blue)
        +string ToString()
    }

    class Sphere {
        +Color Color
        +double Radius
        +int TimesThrown
        +Sphere(Color color, double radius)
        +void Pop()
        +void Throw()
        +string ToString()
    }

    Color <-- Sphere : "Usa"
