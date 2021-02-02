using System;

namespace ConsoleApp1
{
    public class Figure
    {
        public double input;

        public Figure(double RadiusOrSide)
        {
           input = RadiusOrSide;

        }

        static double CalcCircle(double a)
        {
            double Pi = Math.PI;
            double result = Math.Round((a * Pi), 2);
            return result;

        }
        static double CalcArea(double b)
        {
            double result = Math.Round(b * b, 2);
            return result;
        }

        public static void Main(string[] args)
        {

            if (1 == 1)
                {

                Console.WriteLine("What is the radius of the circle? Radius should be more than 0");
                int e = 0;

                while (e < 3)
                { 

                        string InputString = Console.ReadLine();
                        if (InputString.ToString() != string.Empty) // the Convert fails when ""
                        {
                        try
                            {
                                double RadiusOrSideTest = Convert.ToDouble(InputString);
                                var Circle = new Figure(RadiusOrSideTest) { };
                                Console.WriteLine("Radius is " + Circle.input);
                                double MainResultCircle = CalcCircle(Circle.input);
                                Console.WriteLine("The square of the circle is " + MainResultCircle);
                       
                            break;
                        }
                        catch (SystemException sex)
                            {
                            // this class's error string
                            string LastError = sex.Message;
                            Console.WriteLine("Incorrect Input, error" + LastError);
                            Console.WriteLine("Try again to populate correct radius of circle");
                            e ++;

                        }

                    }

                    else
                        {
                            Console.WriteLine("Empty input");
                        }

                    }

                if (e == 3) { 

                    double minNumber = 0.5;
                    double maxNumber = 5.0;
                    double RadiusOrSide = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
                    Figure OtherCircle = new Figure(RadiusOrSide) { };
                    Console.WriteLine("Random value is " + OtherCircle.input);
                    double MainResultCircle = CalcCircle(OtherCircle.input);
                    Console.WriteLine("The square of the circle is " + MainResultCircle);

                }

                if (2 == 2)
                {

                    Console.WriteLine("What is the side of the square? Should be more than 0");
                    int u = 0;

                    while (u < 3)
                    {

                        string InputString = Console.ReadLine();
                        if (InputString.ToString() != string.Empty) // the Convert fails when ""
                        {
                            try
                            {
                                double RadiusOrSideTest = Convert.ToDouble(InputString);
                                var Square = new Figure(RadiusOrSideTest) { };
                                Console.WriteLine("Side is " + Square.input);
                                double MainResultSquare = CalcArea(Square.input);
                                Console.WriteLine("The area of the sqaure is " + MainResultSquare);
                                break;
                            }
                            catch (SystemException sex)
                            {
                                // this class's error string
                                string LastError = sex.Message;
                                Console.WriteLine("Incorrect Input, error" + LastError);
                                Console.WriteLine("Try again to populate correct side of the square");
                                u++;

                            }

                        }

                        else
                        {
                            Console.WriteLine("Empty input");
                        }

                    }

                    if (u == 3)
                    {

                        double minNumber = 0.5;
                        double maxNumber = 5.0;
                        double RadiusOrSide = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
                        Figure OtherSquare = new Figure(RadiusOrSide) { };
                        Console.WriteLine("Random side is " + OtherSquare.input);
                        double MainResultSquare = CalcArea(OtherSquare.input);
                        Console.WriteLine("The area of the square is " + MainResultSquare);
                    }
                }


            }


            Console.WriteLine("The end");


        }
        }
             

}
