# BetterColorSpheres

## Diagrama UML das Classes

```mermaid
classDiagram
    class Color {
        +int Red { get; }
        +int Green { get; }
        +int Blue { get; }
        +int Alpha { get; }
        +int Grey { get; }
        -int Clamp(int value)
        +Color(int red, int green, int blue, int alpha)
        +Color(int red, int green, int blue)
    }

    class Sphere {
        +Color Color { get; }
        +double Radius { get; private set; }
        +int TimesThrown { get; private set; }
        +Sphere(Color color, double radius)
        +void Pop()
        +void Throw()
    }

    class Program {
        +static void Main()
    }

    Sphere --> Color
