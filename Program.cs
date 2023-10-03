using System.Reflection.Metadata.Ecma335;
using static Classes.Program.Circle;

namespace Classes
{
    // Olov Olsson Sundqvist .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcomes user to the program
            Console.WriteLine("Välkommen!");
            // Creating first and second instance of the Circle class, set value to 5 and 6.
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            // Printing out the area of a circle with the radius 5. Math.Round to only use two decimals in answer.
            Console.WriteLine("Arean av en cirkel med 5 cm radie är " + Math.Round(circle1.GetArea(), 2) + " cm²");
            // Printing out the area and circumference of a sphere with the radius 5. Using only 2 decimals in answer.
            Console.WriteLine("En sfär/boll med samma radie har arean " + Math.Round(circle1.GetSurfaceArea(), 2) + " cm2² och omkretsen " + Math.Round(circle1.GetCircumference(), 2) + "cm.");
            // Printing out the area of a circle with the radius 6. Math.Round to only use two decimals in answer.
            Console.WriteLine("Arean av en cirkel med 6 cm radie är " + Math.Round(circle2.GetArea(), 2) + " cm²");
            // Printing out the area and circumference of a sphere with the radius 6. Using only 2 decimals in answer.
            Console.WriteLine("En sfär/boll med samma radie har arean " + Math.Round(circle2.GetSurfaceArea(), 2) + " cm2² och omkretsen " + Math.Round(circle2.GetCircumference(), 2) + "cm.");
            // Asks the user to input a radius of a circle.
            Console.WriteLine("\nSkriv in radien i cm på en valfri cirkel så räknar jag ut arean åt dig");
            Console.WriteLine("(Decimaler separeras med kommatecken [,] och inte med punkt [.]!)\n");
            // ASCII art of a circle to show the user what the radius is.
            Console.WriteLine("    @@@@@@@@");
            Console.WriteLine("  @@        @@");
            Console.WriteLine(" @@          @@");
            Console.WriteLine("@@     .______@@");
            Console.WriteLine("@@      RADIE @@");
            Console.WriteLine(" @@          @@");
            Console.WriteLine("  @@        @@");
            Console.WriteLine("    @@@@@@@@\n");

            // While loop for exception handling
            while (true)
                try
                {
                    // Takes input from user and prints the area of a circle with that input and also the area and circumference of a sphere.
                    Console.Write("Radien: ");
                    float radiusInput = float.Parse(Console.ReadLine());
                    // Creating third instance of the Circle class, set value to user input in 'radiusInput'.
                    Circle circle3 = new Circle(radiusInput);
                    Console.WriteLine("Din cirkels area är: " + Math.Round(circle3.GetArea(), 2) + " cm²");
                    Console.WriteLine("En sfär/boll med samma radie har arean " + Math.Round(circle3.GetSurfaceArea(), 2) + " cm2² och omkretsen " + Math.Round(circle3.GetCircumference(), 2) + "cm.");
                    break;
                }
                catch
                {
                    // If user does an input wrong, showing an error message and give the user a new chance.
                    Console.WriteLine("Något blev fel. Kom ihåg att bara siffror och kommatecken är godkända (ex. 2,5). Prova igen!");
                }

            // Pause the program and clean the console for design and user experience purpose.
            Console.WriteLine("\nTryck på valfri tangent för att gå vidare...");
            Console.ReadKey();
            Console.Clear();
            // Unicode to show the "up arrow" used in ASCII art of triangle.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Asks the user to input the base and height of triangle.
            Console.WriteLine("Jag kan även räkna ut arean på trianglar. Vänligen fyll i basen och höjden på triangeln du vill räkna ut.");
            Console.WriteLine("(Decimaler separeras med kommatecken [,] och inte med punkt [.]!)\n");
            // ASCII art to show the user what the base and height of a triangle is.
            Console.WriteLine("      /\\      ʌ"); //<--- This one needed unicode to show correctly.
            Console.WriteLine("     /  \\     |");
            Console.WriteLine("    /    \\    |");
            Console.WriteLine("   /      \\ HÖJDEN");
            Console.WriteLine("  /        \\  |");
            Console.WriteLine(" /          \\ |");
            Console.WriteLine("/____________\\v");
            Console.WriteLine(" <--BASEN-->\n");

            // While loop for exception handling
            while (true)
                try
                {
                    // Takes input from user and prints the area of a triangle.
                    Console.Write("Basen: ");
                    float triangleBaseInput = float.Parse(Console.ReadLine());
                    Console.Write("Höjden: ");
                    float triangleHeightInput = float.Parse(Console.ReadLine());
                    // Creating triangle instance that takes user inputs as values.
                    Triangle triangle1 = new Triangle(triangleBaseInput, triangleHeightInput);
                    Console.WriteLine("Triangelns area är: " + Math.Round(triangle1.GetTriangleArea(), 2) + "cm²");
                    break;
                }
                catch
                {
                    // If user does an input wrong, showing an error message and give the user a new chance.
                    Console.WriteLine("Något blev fel. Kom ihåg att bara använda siffror och kommatecken. Prova igen!\n");
                }

            // Exiting program.
            Console.Write("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }

        // New class for circles.
        public class Circle
        {
            // Creating new variables for pi and radius.
            float _pi = 3.141f;
            public float _radius;
            // Constructor that gets value from user inputs
            public Circle(float radius)
            {
                _radius = radius;
            }
            // Creating a method that calculates area from pi and radius on a circle.
            public float GetArea()
            {
                return _pi * _radius * _radius;
            }
            // Creating a method that calculates the area of a sphere by using pi and radius.
            public float GetSurfaceArea()
            {
                return 4 * _pi * _radius * _radius;
            }
            // Creating a method that calculates the circumference of a sphere by using pi and radius.
            public float GetCircumference()
            {
                return 2 * _pi * _radius;
            }
        }   

        // Creating a class for triangle
        public class Triangle
        {
            // Creating variables for the triangle base and triangle height.
            public float _triangleBase;
            public float _triangleHeight;
            // Constructor that gets value from user inputs
            public Triangle(float triangleBase, float triangleHeight)
            {
                _triangleBase = triangleBase;
                _triangleHeight = triangleHeight;
            }
            // Creating a method that calculates the area of a triangle using triangleBase and triangleHeight.
            public float GetTriangleArea()
            {
                return _triangleBase * _triangleHeight / 2;
            }
        }
    }
}