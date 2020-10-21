using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Shipment
{
    class Container
    {
        public enum Size { large, small };
        int rWeight;
        int id;
        bool deployed;
        

        public Container(Size weight,int id)
        {
            this.id = id;

            if (weight == 0)
            {
                this.rWeight= 1500;
            }
            else
            {
                this.rWeight = 800;
            } 
        }

        public bool getDeployed()
        {
            return this.deployed;
        }

        public void setDeployed(bool deployed)
        {
            this.deployed = deployed;
        }


        public int getRWeight()
        {
            return this.rWeight;
        }
        
    }
}
