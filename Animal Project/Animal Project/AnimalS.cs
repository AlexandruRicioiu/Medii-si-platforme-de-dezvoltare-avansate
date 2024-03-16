using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Project
{
    internal class AnimalS
    {
        string[] animals = { "pig", "hen", "dog", "cat"};
        string[] sounds = {"groh", "piu", "ham", "miua" };

        public void AnimalSound()
        {
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine( animals[i] + " makes sound " + sounds[i] + " " + sounds[i]);
            }
        }
    }
}
