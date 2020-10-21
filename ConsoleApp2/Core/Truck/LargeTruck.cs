using System;
using System.Collections.Generic;
using System.Text;

namespace DocksGestionApp.Core.Shipment
{
    class LargeTruck:Truck
    {
        public const int cWeight = 1500;
        public const bool full = false;
        public const int remainingC = 2;
        public const String name = "Large Truck";
        
        public LargeTruck(int id)
            : base(id,cWeight, full,remainingC)
        {

        }


        public override string ToString()
        {
            return name + " " + base.ToString();
        }
    }
}
