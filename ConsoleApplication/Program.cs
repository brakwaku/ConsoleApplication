using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kwaku Appau-Nkansah";
            string location = "Rexburg, Idaho, USA";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am at {location}");

            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is {currentDate.ToLongDateString()}");

            var nextChristmas = new DateTime(currentDate.Year, 12, 25);

            var daysUntilXmas = (nextChristmas - currentDate).Days;

            Console.WriteLine($"There are {daysUntilXmas} until christmas");


            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please enter the width of the glass");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height of the glass");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();
        }
    }
}
