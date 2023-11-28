using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Q___set1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int getinteger(string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        public static double getdouble(string information)
        {
            Console.WriteLine(information);
            double number = double.Parse(Console.ReadLine());
            return number;
        }
        public static void Q1()
        {
            int firstvalue = getinteger("enter the first value");
            int secountvalue = getinteger("enter the second value");
            int addresult = addition(firstvalue, secountvalue);
            int diffresult = difference(firstvalue, secountvalue);
            int prodresult = product(firstvalue, secountvalue);
            Console.WriteLine("the addition of two numbers:"+addresult);
            Console.WriteLine("the difference of two numbers:"+diffresult);
            Console.WriteLine("the product of two numbers:"+prodresult);
        }
        public static int addition(int a, int b)
        {
            return a + b;
        }
        public static int difference(int a, int b)
        {
            return (Math.Abs(a - b));
        }
        public static int product(int a, int b)
        {
            return a * b;
        }

        public static void Q2()
        {
            int firstvalue = getinteger("enter the first value");
            int secountvalue = getinteger("enter the second value");
            double result = powerinteger(firstvalue,secountvalue);
            Console.WriteLine(result);
        }
        public static double powerinteger(int a, int b)
        {
            return (Math.Pow(a , b));
        }
        public static void Q3()
        {
            double length = getdouble("enter the value for lenth");
            double width = getdouble("enter the value for width");
            double heigth = getdouble("enter the value for heigth");
            Console.WriteLine("the volume of rectangle is:"+result);
        }
        public static double volumeofrectangle(double l, double w , double h)
      {
        return l * w * h;
      }
      public static void Q4()
{
    int radius = getinteger("enter the value for radius");
    double result = perimeterofcircle(radius);
    Console.WriteLine("primeter of the circle:"+result);

}
      public static double perimeterofcircle(int r)
      {
          double pi = Math.PI;
          return (2 * pi * r);
      }
      public static void Q5()
      {
          int numerator = getinteger("enter the numerator value");
          int denominator = getinteger("enter the denominator value");
          int Quotresult = quotient(numerator, denominator);
          int remairesult = remainder(numerator, denominator);
          Console.WriteLine("the Quotient and the remainder is :{0}:{1}",Quotresult,remairesult);
      }
      public static int quotient(int a, int b)
      {
          return a / b;

      }
      public static int remainder (int a , int b)
      {
          return a % b;
      }

      public static void Q6()
      {
          int value = getinteger("enter the  value to find the square value:");
          int result = squarevalue(value);
          Console.WriteLine("the square value of the given number is:"+result);
      }
        public static int squarevalue(int a)
        {
            return a * a;
        }
        public static void Q7()
        {
            int value = getinteger("enter the value to find the square root value :");
            double result = squarerootvalue(value);
            Console.WriteLine("the square root value of the given number is :"+result);
        }
        public static double squarerootvalue(int num)
        {
            return(Math.Sqrt(num));
        }
        public static void Q8()
        {
            double breadth = getdouble("enter the value for breadth");
            double heigth = getdouble("enter the value for heigth");
            double result = AreaOfTriangle(breadth, heigth);
            Console.WriteLine("the area of the triangle is :"+result);
        }
        public static double AreaOfTriangle(double b, double h)
        {
            return (1 / 2.0 * (b * h));
        }
    }
}






















