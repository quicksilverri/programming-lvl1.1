using System;

namespace AreaAndVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the length of a side: ");
            int length = Convert.ToInt32(Console.ReadLine());

            double volume = 5 * (3 + Math.Pow(5, 0.5)) * Math.Pow(length, 3) / 12;
            double area = 5 * Math.Pow(3, 0.5) * Math.Pow(length, 2);

            Console.WriteLine("Volume of the icosahedron: {0}, surface area of the icosahedron: {1}", volume, area);
        }
    }
}
