using OOP_Basics;
using System.Reflection.Metadata.Ecma335;
using static Classes.Program;

namespace Classes
{
    // Olov Olsson Sundqvist .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcomes user to the program
            Console.WriteLine("Välkommen!\n");
            // Creating first and second instance of the Circle class, set value to 5 and 6.
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            // Printing out the area of a circle with the radius 5.
            circle1.GetCircleArea();
            // Printing out the area and circumference of a sphere with the radius 5.
            circle1.GetSurfaceArea();
            // Printing out the volume of a sphere with the radius 5.
            circle1.GetCircleVolume();
            // New line for design purpose
            Console.WriteLine();
            // Printing out the area of a circle with the radius 6.
            circle2.GetCircleArea();
            // Printing out the area and circumference of a sphere with the radius 6.
            circle2.GetSurfaceArea();
            // Printing out the volume of a sphere with the radius 6.
            circle2.GetCircleVolume();
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
                    // Printing out the area of a circle with the user input radius.
                    circle3.GetCircleArea();
                    // Printing out the area and circumference of a sphere with the user input radius.
                    circle3.GetSurfaceArea();
                    // Printing out the volume of a sphere with the user input radius.
                    circle3.GetCircleVolume();
                    // Break out of loop.
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
                    // Printing out the area of a triangle with the user input.
                    triangle1.GetTriangleArea();
                    // Break out of loop.
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
    }
}