using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Truck
{
    public class SmallTruck: Truck
    {
        public const int cWeight = 800;
        public const bool full = false;
        public const int remainingC = 1;
        public const String name = "Small Truck";
        public int id;
        public SmallTruck(int id)
            : base(id,cWeight, full,remainingC)
        {

        }

        public override string ToString()
        {
            return name + " " + base.ToString();
        }
    }
}
