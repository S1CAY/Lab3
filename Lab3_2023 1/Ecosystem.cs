using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_1
{
    class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem()
        {
            organisms = new List<LivingOrganism>();
        }

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateEcosystem()
        {
            foreach (var organism in organisms)
            {

                if (organism is IReproducible reproducible)
                {
                    reproducible.Reproduce();
                }

                if (organism is IPredator predator)
                {

                    var prey = organisms.Where(o => o != organism).FirstOrDefault();
                    if (prey != null)
                    {
                        predator.Hunt(prey);
                    }
                }
            }
        }
    }

}
