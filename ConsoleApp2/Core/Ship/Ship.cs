using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Shipment
{
    class Ship
    {
        List<Container> cargo;

        public Ship()
        {
            cargo = new List<Container>();
        }


        public void Add(Container c)
        {
            cargo.Add(c);

        }

        public bool delete(Container c)
        {
            return cargo.Remove(c);
        }

        public List<Container> Cargo
        {
            get;set;
        }

        public void Add(Container[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                cargo.Add(t[i]);
            }
        }

        public List<Container> GetContainers()
        {
            List<Container> freeOnes = new List<Container>();

            foreach (Container t in cargo)
            {
                if (!t.getDeployed())
                {
                    freeOnes.Add(t);
                }
            }
            return freeOnes;
        }
    }

}

