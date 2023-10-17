using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_1
{
    class Microorganism : LivingOrganism, IReproducible
    {
        public string Name { get; set; }

        public Microorganism(string name, int energy, int age, int size) : base(energy, age, size)
        {
            Name = name;
        }

        public void Reproduce()
        {
            Console.WriteLine($"{Name} розмножується.");
        }
    }
}
