using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalS animale = new AnimalS();

            Console.WriteLine("Sounds of animals : \n");
            animale.AnimalSound();

            Console.Read();
        }
    }
}
