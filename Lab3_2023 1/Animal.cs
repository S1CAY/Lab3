using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_1 
{ 

class Animal : LivingOrganism, IReproducible, IPredator
{
    public string Species { get; set; }

    public Animal(string species, int energy, int age, int size) : base(energy, age, size)
    {
        Species = species;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Species} розмножується.");
    }

    public void Hunt(LivingOrganism prey)
    {
        Console.WriteLine($"{Species} полює на {prey.GetType().Name}.");
    }
} }