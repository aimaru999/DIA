
using System;
using System.Collections.Generic;
using System.Text;

namespace DocksGestionApp.Core.Shipment
{
    class Distribution
    {
        List<ShipmentCargo> dist;
        Fleet fleet;
        Ship ship;

        public Distribution(Fleet fleet, Ship ship)
        {
            dist = new List<ShipmentCargo>();
            this.fleet = fleet;
            this.ship = ship;
            
        }

        public void AddShipmentCargo()
        {

            Fleet old=new Fleet(this.fleet.GetFleet());
            ShipmentCargo cargo = new ShipmentCargo(old, this.ship);
           
            bool flag;
            

            do
            {
                
                flag = cargo.AssignFleet();
                dist.Add(cargo);

                this.ship = cargo.GetShip();
                old = new Fleet(this.fleet.GetFleet());
                


                cargo = new ShipmentCargo(old, this.ship);


                


            } while (!flag);

            
        }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            int i = 0;
            foreach(var v in dist)
            {

                str.Append("Travel "+ i + ":\n\n\n\n\n\n ").Append(v.ToString()).Append("\n\n");
                i++;
            }

            return str.ToString();
        }

    }
}
