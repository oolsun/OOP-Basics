using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Circle
    {
        // Creating new variables for pi and radius.
        float _pi = 3.141f;
        float _radius;
        // Constructor that gets value from user inputs
        public Circle(float radius)
        {
            _radius = radius;
        }
        // Creating a method that calculates area from pi and radius on a circle. Using only 2 decimals. Then returns a text with the calculations.
        public void GetCircleArea()
        {
            float circleArea = _pi * _radius * _radius;
            Console.WriteLine("Arean av en cirkel med " + _radius + " cm i radie är " + Math.Round(circleArea, 2) + " cm².");
        }
        // Creating a method that calculates the area and circumference of a sphere by using pi and radius. Using only 2 decimals. Then returns a text with the calculations.
        public void GetSurfaceArea()
        {
            float surfaceArea = 4 * _pi * _radius * _radius;
            float circumference = 2 * _pi * _radius;
            Console.WriteLine("En sfär/boll med samma radie har arean " + Math.Round(surfaceArea, 2) + " cm2² och omkretsen " + Math.Round(circumference, 2) + "cm.");
        }
        // Creating a mehod that calculates the volume of a sphere by using pi and radius. Using only 2 decimals. Then returns a text with the calculations.
        public void GetCircleVolume()
        {
            float volume = 4f / 3f * _pi * _radius * _radius * _radius;
            Console.WriteLine("Volymen är " + Math.Round(volume, 2) + " cm³.");
        }
    }
}
