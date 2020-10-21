using DocksGestionApp.Core.Shipment;
using System;

namespace DocksGestionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fleet fleet = new Fleet();
            Ship ship = new Ship();
            ShipmentCargo cargo = new ShipmentCargo(fleet,ship);
            Distribution distribution = new Distribution(fleet, ship);

            for (int i = 0; i < 3; i++)
            {
                fleet.Add(new LargeTruck(i));
                
                fleet.Add(new SmallTruck(i+10));
                

              

            }

           

           

           

            


            for (int i = 0; i < 4; i++)
            {
                ship.Add(new Container(Container.Size.large, i + 20));
                ship.Add(new Container(Container.Size.small, i + 300));
                
            }

            
           

                distribution = new Distribution(fleet, ship);

            distribution.AddShipmentCargo();



          // Console.WriteLine(distribution.ToString());



        }
    }
}
