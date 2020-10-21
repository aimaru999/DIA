using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DocksGestionApp.Core.Shipment
{
    class Fleet
    {

        List<Truck> fleet;
        int bigNum;
        int smallNum;
        

        public Fleet()
        {
            bigNum = 0;
            smallNum = 0;
            fleet = new List<Truck>();

            
        }

        public Fleet(List<Truck> l)
        {
            bigNum = 0;
            smallNum = 0;
            this.fleet = l.ToList<Truck>();


        }

        public List<Truck> GetFleet()
        {
            return this.fleet;
        }

        public int GetBigNum()
        {
            return this.bigNum;
        }

        public void SetBigNum(int num)
        {
            this.bigNum = num;
        }

        public int GetSmallNum()
        {
            return this.smallNum;
        }

        public void SetSmallNum(int num)
        {
            this.smallNum = num;
        }

        private void IncNum(Truck t)
        {

            if (t.Equals(typeof(LargeTruck)))
            {
                bigNum++;
            }
            else
            {
                smallNum++;
            }
        }

        public void Add(Truck t)
        {
            fleet.Add(t);
            IncNum(t);

        }

        public void Delete(Truck t)
        {
           if(fleet.Remove(t))
            {
                if (t.Equals(typeof(LargeTruck)))
                {
                    bigNum--;
                }
                else
                {
                    smallNum++;
                }
            }


        }

        public void Add(Truck[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                fleet.Add(t[i]);
                IncNum(t[i]);
            }
        }

        public List<Truck> GetFreeTrucks(int num)
        {
            List<Truck> freeOnes = new List<Truck>();

            foreach (Truck t in fleet){

                if (!t.Full) {

                    if (t is LargeTruck && num==0)
                    {
                        freeOnes.Add(t);
                    } else
                    if (t is SmallTruck && num==1)
                    {
                        freeOnes.Add(t);
                        
                    }
                }
            }
            return freeOnes;
        }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            foreach (var t in fleet)
            {
                str.Append(t.ToString());
            }

            return str.ToString();
        }



    }
}
