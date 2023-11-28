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
        public static void Q9()
        {
            int kilometer = getinteger("enter the kilometer to find the mile value :");
            double result = KiloToMiles(kilometer);
            Console.WriteLine("the mile calculetion of the given number is :"+result);
        }
        public static double KiloToMiles(int num)
        {
            double onemile = 1.60934;
            return (num * onemile);
        }
        public static void Q10()
        {
            int celsius = getinteger("enter the celsius :");
            double result = celsiusToFahrenheit(celsius);
            Console.WriteLine("the Fahrenheit of given celsius is :"+result);
        }
        public static double celsiusToFahrenheit(int celsius)
        {
            return ((celsius * 9 / 5.0) + 32);
        }
        public static void Q11()
        {
            int firstvalue = getinteger("enter the value of the first value :");
            int secondvalue = getinteger("enter thye value of the second value :");
            swapTwovalue(firstvalue, secondvalue);
        }
        public static void swapTwovalue(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("the values after swap");
            Console.WriteLine("the value of the first variable:"+a);
            Console.WriteLine("the value of the second variable:"+b);
        }
        public static void Q12()
        {
            int firstvalue = getinteger("enter the value of  first variable :");
            int secondvalue = getinteger("enter the value of  second variable");
            SwapWithoutTempvar(firstvalue, secondvalue);
        }
        public static void SwapWithoutTempvar(int a, int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("the value after swap");
            Console.WriteLine("the value of first value"+a);
            Console.WriteLine("the value if second value"+b);
        }
        public static void Q13()
        {
            int firstvalue = getinteger("enter the value of  first variable :");
            int secondvalue = getinteger("enter the value of  second variable");
            swapwithoutcausingOverFlow(firstvalue, secondvalue);
        }
        public static void swapwithoutcausingOverFlow(int a, int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("the value after swap");
            Console.WriteLine("the value of first value" + a);
            Console.WriteLine("the value if second value" + b);
        }
        public static void Q14()
        {
            int starting = getinteger("enter the staring range for generating the random values :");
            int end = getinteger("enter the ending range of generating the random values :")
                int result = Randomvalues(starting, end);
            Console.WriteLine("the random value is :"+result);
        }
        public static int Randomvalues(int a, int b)
        {
            Random r = new Random();
            int random = r.Next(a, b);
            return random;
        }
        public static void Q15()
        {
            double length = getdouble("enter the length in field");
            double width = getdouble("enter the width in field");

            double result = AreaOffieldinAcers(length, width);
            Console.WriteLine(result);
        }
        public static double AreaOffieldinAcers(double length, double width)
        {
            int oneAcer = 43560;
            return (length * width / oneAcer);

        }
        public static void Q16()
        {
            int number = getinteger("enter the number");
            double result = sumNaturalNumbers(number);
            Console.WriteLine(result);
        }
        public static double sumNaturalNumbers(int num)
        {
            return (num * (num + 1) / 2);
        }
        public static void Q17()
        {
            int mark1 = getinteger("enter the mark in first subject :");
            int mark2 = getinteger("enter the mark in second subject :");
            int mark3 = getinteger("enter the mark in third subject :");
            Console.WriteLine(average(mark1 , mark2 , mark3));
        }
        public static double average(int a , int b , int c )
        {
            double total = a + b + c;
            return (total / 3);
        }
        public static void Q18()
        {
            double bill = getdouble("enter the bill amount:");
            Console.WriteLine("your bill with tax:"+calculateTip(bill));
        }
        public static double calculateTip(double bill)
        {
            return (bill+(bill*(5 / 100.0)));
        }
         public static void Q19()
         {
             double bill = getdouble("enter the bill amount :");
             int tax = getinteger("enter the tax percentage:");
             Console.WriteLine("the net amount is:"+calculateNetamount(bill,tax));
         }
        public static double calculateNetamount(double amount,int taxpercent)
        {
            double netamount = (amount /(1 + (taxpercent / 100.0)));
            return netamount;
        }
        public static void Q20()
        {
            double basicpay = getdouble("enter the percent of basic pay:");
            double DA = getdouble("enter the percent of DA:");
            double TA = getdouble("enter the percent of TA :");
            Console.WriteLine("the grosspay is :"+grosspay(basicpay,DA,TA));
        }
        public static double  grosspay(double basicpay , double DA, double TA)
        {
            double da=basicpay*(DA/100.0);
            double ta=basicpay*(TA/100.0);
            double PF =basicpay*(8 / 100.0);
            double grosspay = basicpay + da + ta - PF;
            return grosspay;
        }
        public static void Q21()
        {
            int princple = getinteger("enter the princple amount:");
            int numberoftime = getinteger("enter the number of time period");
            double rate = getdouble("enter the rate:");
            Console.WriteLine("the calculate simple interest is :"+simpleinterest(princple , numberoftime ,rate));
        }
        public static double simpleinterest(int p, int n, double r)
        {
            double si = (p * n * (r / 100.0));
            return si;
        }
        public static void Q22()
        {
            int princple = getinteger("enter the princple amount:");
            int numberoftime = getinteger("enter the number of time period:");
            int timeduration = getinteger("enter the time duration: ");
            int rate = getinteger("enter the rate :");
            Console.WriteLine("the compound interest is:" + compoundinterest(princple, numberoftime, timeduration,rate));
        }
        public static double compoundinterest(int p, int n, int t, int r)
        {
            double compoundinterest = (p * ((1 + r / n) ^ (n * t)));
            return compoundinterest;
        }
        public static void Q24()
    {
        int height = getinteger("enter your height :");
        int weight = getinteger("enter you weight");
        Console.WriteLine("the body mass index of the given height and weight is"+calculateBMI(height , weight));
    }
        public static double calculateBMI(int height, int weight)
        {
            int division = quotient(height, weight);
            double output = product(division, height);
            return output;
        }
        public static void Q25()
        {
            student();
        }
        public static void student()
        {
            int rollno = getinteger("enter the your roll number :");
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            int mark1 = getinteger("enter your mark in subject1 :");
            int mark2 = getinteger("enter your mark in subject2 :");
            int mark3 = getinteger("enter your mark in subject3 :");
            int total = mark1 + mark2 + mark3;
            Console.WriteLine("mark in sub1 is:{0} , sub2 is:{1} and sub3 is :{2}",mark1,mark2,mark3);
            Console.WriteLine("total :"+total);
            Console.WriteLine("avrg is:"+average(mark1 , mark2 , mark3));
        }
    }
}






















