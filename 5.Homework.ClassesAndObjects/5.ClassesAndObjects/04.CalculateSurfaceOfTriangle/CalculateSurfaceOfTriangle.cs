//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
using System;

namespace CalculateSurfaceOfTriangle
{
    class CalculateSurfaceOfTriangle
    {
        static void Main()
        {
            Console.WriteLine("This program will calculate the surface of triangle by given:\n1)Side and altitude to it.\n2)Three sides.\n3)Two sides and angle betweeen them.");
            int option = 0;
            while (option < 1 || option > 3)
            {
                Console.WriteLine("Choose of the three options by entering 1, 2 or 3.");
                option = int.Parse(Console.ReadLine());
            }
            double surface = 0;

            switch (option)
            {
                case 1: surface = SurfaceBySideAndAltitude(); break;
                case 2: surface = SurfaceByThreeSides(); break;
                case 3: surface = SurfaceByTwoSidesAndAngle(); break;
            }
            Console.WriteLine("The surface of your triangle is {0:f2} square cantimeters.", surface);
        }

        static double SurfaceBySideAndAltitude()
        {
            //S = ½*(a*ha)
            Console.Write("Enter side in cm = ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude/height in cm = ");
            double height = double.Parse(Console.ReadLine());
            ValidationOfSide(side, height);
            double surface = (side * height) / 2;
            return surface;
        }

        static double SurfaceByThreeSides()
        {
            //Using this formula:
            //     ______________________
            //S = √p(p - a)(p - b)(p - c) 
            //where p is semiperimeter
            Console.Write("Enter side a in cm = ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Enter side b in cm = ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Enter side c in cm = ");
            double sideThree = double.Parse(Console.ReadLine());
            ValidationOfSide(sideOne, sideTwo, sideThree);
            double p = (sideOne + sideTwo + sideThree) / 2;
            double parameterUnderRadical = p * (p - sideOne) * (p - sideTwo) * (p - sideThree);
            if (parameterUnderRadical <= 0)
            {
                throw new ArgumentException("Entered values cannot form a triangle!");
            }
            double surface = Math.Sqrt(parameterUnderRadical);
            return surface;
        }

        static double SurfaceByTwoSidesAndAngle()
        {
            //S = ½(a*b*sinC) = ½(a*c*sinB) = ½(b*c*sinA) 
            Console.Write("Enter side a in cm = ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Enter side b in cm = ");
            double sideTwo = double.Parse(Console.ReadLine());
            ValidationOfSide(sideOne, sideTwo);
            Console.Write("Enter angle in degrees = ");
            double angle = double.Parse(Console.ReadLine());
            if (angle <= 0 || angle >= 180)
            {
                Console.WriteLine("Incorrect Input of angle! 0 < angle < 180");
                Environment.Exit(0);
            }
            //1 radians = 57.2957795 degrees - Math.Sin() works with radians
            angle = angle / 57.2957795;
            double sinOfangle = Math.Sin(angle);
            double surface = (sideOne * sideTwo * sinOfangle) / 2;
            return surface;
        }

        static void ValidationOfSide(params double[] arrOfNumbers)
        {
            foreach (var number in arrOfNumbers)
            {
                if (number < 0)
                {
                    throw new ArgumentException("Incorrect value! You cannot enter value below zero (< 0) for side!");
                }
            }
        }
    }
}
