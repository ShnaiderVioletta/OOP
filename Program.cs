using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Point
    {
        public int X;
        public int Y;
    }
    class Man
    {
        public string name;
        public int age 
        { 
            get { return age; }
            set 
            { 
                if((age>=0)&&(age<100))
                    age = value; 
            } 
        }
        private int money;
        public Point Geolocation { get; set; }
        public Man()
        {
            Console.WriteLine("Hello, world! I was born!");
            name = "";
            age = 0;
            money = 0;
        }

        public Man(string tmpName, int tmpAge, int tmpMoney)
        {
            age = tmpAge;
            name = tmpName;
            money = tmpMoney;
        }

        public void SetMoney(int tmpMoney)
        {
            money = tmpMoney;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Man person = new Man("Vanya", 30, 10);
            person.SetMoney(20);
            Point tmppoint = new Point();
            tmppoint.X = 10;
            tmppoint.Y = 15;

            person.Geolocation = tmppoint;
        }
    }
}
