using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsoleApp2.Core.Truck
{
    class Fleet
    {

        List<Truck> fleet;

        public Fleet()
        {
            fleet = new List<Truck>();
        }


        public void Add(Truck t)
        {
            fleet.Add(t);

        }

        public bool delete(Truck t)
        {
           return fleet.Remove(t);
        }

        public void Add(Truck[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                fleet.Add(t[i]);
            }
        }

        public List<Truck> GetFreeTrucks()
        {
            List<Truck> freeOnes = new List<Truck>();

            foreach (Truck t in fleet){
                if (!t.Full)
                {
                    freeOnes.Add(t);
                }
            }
            return freeOnes;
        }

        public List<Truck> GetFreeLargeTrucks()
        {
            
            List<Truck> freeOnes = GetFreeTrucks();
            List<Truck> largeOnes = new List<Truck>();

            foreach (var t in freeOnes) {
                if (!t.Equals(typeof(LargeTruck)))
                {
                    largeOnes.Add(t);
                }
            }
            return largeOnes;
        }



    }
}
