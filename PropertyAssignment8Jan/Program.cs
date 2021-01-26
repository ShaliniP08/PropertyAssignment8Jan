using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAssignment8Jan
{
    class Date
    {
        int day, month, year;

        #region Properties

        public int Day
        {
            get { return day; }
            set
            {
                if (value>=1 && value<=31)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("The day entered is incorrect");
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("The month entered is incorrect");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 2011 && value <= 2020)
                {
                    year = value; 
                }
                else
                {
                    Console.WriteLine("The year entered is incorrect");
                }
            }
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date obj = new Date();
            Console.WriteLine("Enter day,month,year in the order");
            obj.Day = int.Parse(Console.ReadLine());
            obj.Month = int.Parse(Console.ReadLine());
            obj.Year = int.Parse(Console.ReadLine());

            if ((obj.Day>=1 && obj.Day <=31) && 
                (obj.Month>=1 && obj.Month<=12) &&
                (obj.Year>=2011 && obj.Year<=2020))
            {
                Console.WriteLine($"Date: {obj.Day}/{obj.Month}/{obj.Year}");
            }
            else
            {
                Console.WriteLine("Wrong Date");
            }

            Console.ReadLine();
        }
    }
}
