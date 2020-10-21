using System;
using System.Collections.Generic;
using System.Text;

namespace DocksGestionApp.Core.Shipment
{
    public class SmallTruck: Truck
    {
        public const int cWeight = 800;
        public const bool full = false;
        public const int remainingC = 1;
        public const String name = "Small Truck";
        
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
