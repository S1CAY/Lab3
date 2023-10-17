using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab3_2023_1


{ interface IReproducible
{
    void Reproduce();
}


interface IPredator
{
    void Hunt(LivingOrganism prey);
}


class Program
{
    static void Main(string[] args)
    {
        Ecosystem ecosystem = new Ecosystem();


        ecosystem.AddOrganism(new Animal("Лев", 100, 5, 10));
        ecosystem.AddOrganism(new Animal("Зебра", 50, 4, 8));
        ecosystem.AddOrganism(new Plant("Дерево", 10, 10, 50));
        ecosystem.AddOrganism(new Microorganism("Бактерія", 2, 1, 1));


        ecosystem.SimulateEcosystem();
    }
} }
