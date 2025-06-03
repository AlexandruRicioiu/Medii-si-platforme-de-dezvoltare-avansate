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
        private Dictionary<string, string> animalSounds = new Dictionary<string, string>
        {
            { "pig", "groh" },
            { "hen", "piu" },
            { "dog", "ham" },
            { "cat", "miua" }
        };

        public void AnimalSound()
        {
            foreach (var animalSound in animalSounds)
            {
                Console.WriteLine($"{animalSound.Key} makes sound {animalSound.Value}");
            }
        }
    }
}
