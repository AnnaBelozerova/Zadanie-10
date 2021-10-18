using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{   //Угол в радианы
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            try
            {
                Console.WriteLine("Введите градусы: ");
                angle.gradus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты: ");
                angle.Min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите секунды: ");
                angle.Sec = Convert.ToInt32(Console.ReadLine());
                angle.ToAngle();
                angle.ToRadians();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t{0}", ex.Message);                
            }    
                  
                    
            Console.ReadKey(); 
        }

    }
    class Angle
    {
        public int gradus { get; set; }        
        int min;
        int sec;

        public int Min
        {
            set
            {
                if (value<=60 && value>=0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("\tДиапазон возможных значений [0 .. 60]");
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
                if (value <= 60 && value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("\tДиапазон возможных значений [0 .. 60]");
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus=0, int min = 0, int sec = 0)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;            
        }
        public void ToAngle()
        {
            Console.WriteLine("{0:f3}", this.gradus + this.min / 60.0 + this.sec / 3600.0);       
        }
        public void ToRadians()
        {
            Console.WriteLine("{0:f2}", (this.gradus + this.min / 60.0 + this.sec/3600.0) *Math.PI/180.0);
        } 
    }
}
