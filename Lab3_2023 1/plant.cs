using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_1
{
    class Plant : LivingOrganism, IReproducible
    {
        public string Type { get; set; }

        public Plant(string type, int energy, int age, int size) : base(energy, age, size)
        {
            Type = type;
        }

        public void Reproduce()
        {
            Console.WriteLine($"{Type} розмножується.");
        }
    }
}
