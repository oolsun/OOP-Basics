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
            // Accessing the Circle class.
            Circle circle = new Circle();
            // Giving the variable radius in circle class the value 5.
            circle.radius = 5;
            // Printing out the area of a circle with the radius 5. Math.Round to only use two decimals in answer.
            Console.WriteLine("Arean av en cirkel med 5 cm radie är " + Math.Round(circle.getArea(), 2) + " cm²");
            // Printing out the area and circumference of a sphere with the radius 5. Using only 2 decimals in answer.
            Console.WriteLine("En sfär/boll med samma radie har arean " + Math.Round(circle.getSurfaceArea(), 2) + " cm2² och omkretsen " + Math.Round(circle.getCircumference(), 2) + "cm.");
            // Giving the variable radius in circle class the value 6.
            circle.radius = 6;
            // Printing out the area of a circle with the radius 6. Math.Round to only use two decimals in answer.
            Console.WriteLine("Arean av en cirkel med 6 cm radie är " + Math.Round(circle.getArea(), 2) + " cm²");
            // Printing out the area and circumference of a sphere with the radius 6. Using only 2 decimals in answer.
            Console.WriteLine("En sfär/boll med samma radie har arean " + Math.Round(circle.getSurfaceArea(), 2) + " cm2² och omkretsen " + Math.Round(circle.getCircumference(), 2) + "cm.");
            // Asks the user to input a radius of a circle.
            Console.WriteLine("\nSkriv in radien i cm på en valfri cirkel så räknar jag ut arean åt dig");
            Console.WriteLine("(Decimaler separeras med kommatecken [,] och inte med punkt [.]!)\n");
            // ASCII art of a circle to show what the radius is.
            Console.WriteLine("    @@@@@@@@");
            Console.WriteLine("  @@        @@");
            Console.WriteLine(" @@          @@");
            Console.WriteLine("@@     .______@@");
            Console.WriteLine("@@      RADIE @@");
            Console.WriteLine(" @@          @@");
            Console.WriteLine("  @@        @@");
            Console.WriteLine("    @@@@@@@@\n");
            // While loop for exception handliing
            while (true)
                try
                {
                    // Takes input from user and prints the area of a circle with that input and also the area and circumference of a sphere.
                    Console.Write("Radien: ");
                    circle.radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("Din cirkels area är: " + Math.Round(circle.getArea(), 2) + " cm²");
                    Console.WriteLine("En sfär/boll med samma radie har arean " + Math.Round(circle.getSurfaceArea(), 2) + " cm2² och omkretsen " + Math.Round(circle.getCircumference(), 2) + "cm.");
                    break;
                }
                catch
                {
                    // If user does an input wrong, showing an error message and give the user a new chance.
                    Console.WriteLine("Något blev fel. Kom ihåg att bara siffror och kommatecken är godkända (ex. 2,5). Prova igen!");
                }
            // Accessing triangle class.
            Triangle triangle = new Triangle();
            // Unicode to show the "up arrow" used in ASCII art of triangle.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Asks the user to input the base and height of triangle.
            Console.WriteLine("\nJag kan även räkna ut arean på trianglar. Vänligen fyll i basen och höjden på triangeln du vill räkna ut.");
            Console.WriteLine("(Decimaler separeras med kommatecken [,] och inte med punkt [.]!)\n");
            // ASCII art to show what the base and height of a triangle is.
            Console.WriteLine("      /\\      ʌ");
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
                    triangle.triangleBase = float.Parse(Console.ReadLine());
                    Console.Write("Höjden: ");
                    triangle.triangleHeight = float.Parse(Console.ReadLine());
                    Console.WriteLine("Triangelns area är: " + Math.Round(triangle.getTriangleArea(), 2) + "cm²");
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
            float pi = 3.141f;
            public float radius;
            // Creating a method that calculates area from pi and radius on a circle.
            public float getArea()
            {
                return pi * radius * radius;
            }
            // Creating a method that calculates the area of a sphere by using pi and radius.
            public float getSurfaceArea()
            {
                return 4 * pi * radius * radius;
            }
            // Creating a methos that calculates the circumference of a sphere by using pi and radius.
            public float getCircumference()
            {
                return 2 * pi * radius;
            }
            // Creating a class for triangle
            public class Triangle
            {
                // Creating variables for the triangle base and triangle height.
                public float triangleBase;
                public float triangleHeight;
                // Creating a method that calculates the area of a triangle using triangleBase and triangleHeight.
                public float getTriangleArea()
                {
                    return triangleBase * triangleHeight / 2;
                }
            }
        }
    }
}