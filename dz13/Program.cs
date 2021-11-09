using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Невский проспект", 35, 12, 28);
            building.Print();
            Console.ReadKey();
        }
    }
    public class Building //создаем класс здание
    {
        public string Addres { get; set; } //адресс здания
        public double L { get; set; } // длина здания
        public double B { get; set; } // ширина здания
        public double H { get; set; } // высота здания
        public Building (string addres,double l,double b, double h) // конмтруктор принимает значения
        {
            Addres = addres;
            L = l;
            B = b;
            H = h;
        }
        public void Print()
        {
            Console.WriteLine("Здание находится на улице {0}\nдлина здания равна {1}\nширина здания равна {2}\nвысота здания равна {3} ", Addres,L,B,H);
        }
    }
}
