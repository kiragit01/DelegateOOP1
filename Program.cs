using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOOP1
{
    class Program
    {
        delegate double SearchDouble(double x, double y, double z);
        static void Main()
        {
            SearchDouble searchDouble;
            searchDouble = SmallDouble;

            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine($"Наименьшее = {searchDouble(x, y, z)}");

            searchDouble = BigDouble;

            Console.WriteLine($"Наибольшее = {searchDouble(x, y, z)}");

            Console.ReadKey();
        }

        static double SmallDouble(double x, double y, double z)
        {
            if (x < y && x < z) return x;
            if (y < z && y < x) return y;
            if (z < x && z < y) return z;
            return 0;
        }

        static double BigDouble(double x, double y, double z)
        {
            if (x > y && x > z) return x;
            if (y > z && y > x) return y;
            if (z > x && z > y) return z;
            return 0;
        }

    }
}