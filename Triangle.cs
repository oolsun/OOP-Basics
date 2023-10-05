using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    internal class Triangle
    {
        // Creating variables for the triangle base and triangle height.
        float _triangleBase;
        float _triangleHeight;
        // Constructor that gets value from user inputs
        public Triangle(float triangleBase, float triangleHeight)
        {
            _triangleBase = triangleBase;
            _triangleHeight = triangleHeight;
        }
        // Creating a method that calculates the area of a triangle using triangleBase and triangleHeight. Then returns a text with the calculations.
        public void GetTriangleArea()
        {
            float triangleArea = _triangleBase * _triangleHeight / 2;
            Console.WriteLine("Triangelns area är: " + Math.Round(triangleArea, 2) + "cm²");
        }
    }
}
