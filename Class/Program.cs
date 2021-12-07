using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(60, 20, 20);         
            angle.Print();
            angle.ToRadians();         
            Console.ReadKey();
        }

    }
    class Angle
    {
        public int Gradus { get; set; }
        int min;
        int sec;

        public int Min
        {
            set
            {
                if (value > 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение не может быть отрицательным");
                }

            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value > 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение не может быть отрицательным");
                }

            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;            
        }

        public void Print()
        {
            Console.WriteLine($"Градус равен: {Gradus} {Min} {Sec}");
        }
        public void ToRadians()
        {
            double a = Math.PI * Gradus / 180;
            Console.WriteLine($"Радиан равен: {a}");
        }

    }

}