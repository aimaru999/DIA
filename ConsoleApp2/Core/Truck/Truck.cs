using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Truck
{
    public abstract class Truck
    {
        int cWeight;
        bool full;
        int remainingC;
        int id;

        protected Truck(int id,int cWeight, bool full, int remainingC)
        {
            this.id = id;
            this.cWeight = cWeight;
            this.full = full;
            this.remainingC = remainingC;

        }

        public int Id
        {
            get;set;
        }



        public bool Full
        {
            get; set;
        }

        public override String ToString(){
            StringBuilder str = new StringBuilder();
            if (this.cWeight == 1500) {
                str.Append(cWeight / 1000).Append("Tm").Append("\n");
                
            }
            else
            {
                str.Append(cWeight).Append("Kg").Append("\n");
            }

            str.Append("Is it full: ").Append(this.full);
            str.Append("Slots to fill").Append(this.remainingC);

            return str.ToString();

        }

        


    }
}
