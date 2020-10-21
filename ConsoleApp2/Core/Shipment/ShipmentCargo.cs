using ConsoleApp2.Core.Truck;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Shipment
{
    class ShipmentCargo
    {
        Fleet fleet;
        Ship ship;

        public ShipmentCargo(Fleet fleet,Ship ship)
        {
            this.fleet = fleet;
            this.ship = ship;
        }

        public void AssignFleet()
        {
            List <Container> auxContainer= this.ship.GetContainers();
            


            foreach (Container c in auxContainer)
            {
                foreach(var t in this.fleet.GetFreeLargeTrucks())
                {
                    if (c.getRWeight() == 1500)
                    {
                        t.Full = true;
                        c.setDeployed(true); 
                        
                    }
                }
            }
        }


    }
}
