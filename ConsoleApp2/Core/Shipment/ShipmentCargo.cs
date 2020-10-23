
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace DocksGestionApp.Core.Shipment
{
    class ShipmentCargo
    {
        Fleet fleet;
        Ship ship;

        public ShipmentCargo(Fleet fleet, Ship ship)
        {
            this.fleet = fleet;
            this.ship = ship;
        }


       public Ship GetShip()
        {
            return this.ship;
        }


        public bool AssignFleet()
        {
            bool solo = true;
            
            //list of free Large Trucks
            var largeTruckList = fleet.GetFreeTrucks(0);
            //list of fre Small Trucks
            var smallTruckList = fleet.GetFreeTrucks(1);

            //list of free Large Containers
            var largeContainerList = ship.GetContainers(0);
            //list of free Small Containers
            var smallContainerList = ship.GetContainers(1);
            


            //There are enough big Trucks for the big Containers
            if (largeTruckList.Count >= largeContainerList.Count)
            {
                
                for (int i = 0; i < largeContainerList.Count; i++)
                {
                    this.fleet.Delete(largeTruckList[i]);

                    largeTruckList[i].SetContainer(largeContainerList[i]);
                    ship.Delete(largeContainerList[i]);

                    this.fleet.Add(largeTruckList[i]);
                }

                largeTruckList = fleet.GetFreeTrucks(0);

                //There are enough big Trucks for the small Containers
                if (largeTruckList.Count >= smallContainerList.Count/2)
                {
                    int j = 0;
                    for (int i = 0; i < smallContainerList.Count; i++)
                    {
                        j = i / 2;

                        this.fleet.Delete(largeTruckList[j]);

                        largeTruckList[j].SetContainer(smallContainerList[i]);
                        ship.Delete(smallContainerList[i]);

                        this.fleet.Add(largeTruckList[j]);


                    }
                //There are not enough big Trucks for the small Containers
                }else if(largeTruckList.Count < smallContainerList.Count / 2)
                {

                    int j = 0;
                    for (int i = 0; i < largeTruckList.Count*2; i++)
                    {
                        j = i / 2;

                        this.fleet.Delete(largeTruckList[j]);

                        largeTruckList[j].SetContainer(smallContainerList[i]);
                        ship.Delete(smallContainerList[i]);

                        this.fleet.Add(largeTruckList[i]);

                    }

                    smallContainerList = ship.GetContainers(1);

                    //There are enough small Trucks for the small Containers
                    if(smallTruckList.Count >= smallContainerList.Count)
                    {
                        for (int i = 0; i < smallContainerList.Count; i++)
                        {
                            this.fleet.Delete(smallTruckList[i]);

                            smallTruckList[i].SetContainer(smallContainerList[i]);
                            ship.Delete(smallContainerList[i]);

                            this.fleet.Add(smallTruckList[i]);
                        }
                    }
                    //There are not enough small Trucks for the small Containers
                    else
                    {
                        for (int i = 0; i < smallTruckList.Count; i++)
                        {
                            this.fleet.Delete(smallTruckList[i]);

                            smallTruckList[i].SetContainer(smallContainerList[i]);
                            ship.Delete(smallContainerList[i]);

                            this.fleet.Add(smallTruckList[i]);

                        }

                        solo = false;


                    }

                }
                


            }
            //There are not enough big Trucks for the big Containers
            else if(largeTruckList.Count < largeContainerList.Count)
            {
                for (int i = 0; i < largeTruckList.Count; i++)
                {
                    this.fleet.Delete(largeTruckList[i]);

                    largeTruckList[i].SetContainer(largeContainerList[i]);
                    ship.Delete(largeContainerList[i]);

                    this.fleet.Add(largeTruckList[i]);

                }

               

                //There are enough small Trucks for the small Containers
                if (smallTruckList.Count >= smallContainerList.Count)
                {
                    for (int i = 0; i < smallContainerList.Count; i++)
                    {
                        this.fleet.Delete(smallTruckList[i]);

                        smallTruckList[i].SetContainer(smallContainerList[i]);
                        ship.Delete(smallContainerList[i]);

                        this.fleet.Add(smallTruckList[i]);

                    }
                }
                //There are not enough small Trucks for the small Containers
                else
                {
                    for (int i = 0; i < smallTruckList.Count; i++)
                    {
                        this.fleet.Delete(smallTruckList[i]);

                        smallTruckList[i].SetContainer(smallContainerList[i]);
                        ship.Delete(smallContainerList[i]);


                        this.fleet.Add(smallTruckList[i]);

                    }
   

                }

                solo = false;
            }

            
            return solo;
        }

        public override string ToString()
        {
            return fleet.ToString();
        }



    }
}
