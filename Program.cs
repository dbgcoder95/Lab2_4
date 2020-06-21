using System;

namespace lab2._4
{
    class Program
    {
        static void Main(string[] args)		

        {
            int myFirstNumber = 19;
            int mySecondNumber = 244;
            int results = myFirstNumber * mySecondNumber;
            Console.WriteLine(results);
            string myText = "Some Text";
            string results1 = "Some Text" + 19.ToString();
            Console.WriteLine(results1);
            string moreText = " Goes Here";
            String results2 = myText + moreText;
            Console.WriteLine(results2);
            string color1 = "Yellow";
            string color2 = "Red";
            bool isYellow = true;
            bool isGreen = false;
            Console.WriteLine(color1);
            Console.WriteLine(color2);
            Console.WriteLine(isYellow);
            Console.WriteLine(isGreen);
            double numbers;
            numbers = mySecondNumber / myFirstNumber;
            Console.WriteLine(numbers);
            Console.WriteLine("Breakpoint Here");
        }
    }
}
