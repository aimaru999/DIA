using System;
using System.Collections.Generic;
using System.Text;

namespace DocksGestionApp.Core.Shipment
{
    public class Container
    {
        public enum Size { large, small };
        int rWeight;
        int id;
        bool deployed;
        

        public Container(Size weight,int id)
        {
            this.id = id;

            if (weight== Size.large)
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

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Container ID: ").Append(this.id).Append("\n");
            str.Append("Weight:").Append(this.rWeight).Append(" Kg.\n\n");



            return str.ToString();
        }
    }
}
