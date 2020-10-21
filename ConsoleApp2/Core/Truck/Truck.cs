
using System;
using System.Collections.Generic;
using System.Text;

namespace DocksGestionApp.Core.Shipment
{
    public abstract class Truck
    {
        int cWeight;
        bool full;
        int remainingC;
        int id;
        List<Container> c;

#pragma warning disable CS8618 // La instancia de propiedad "Container" que acepta valores NULL está sin inicializar. Considere la posibilidad de declarar la instancia de propiedad como capaz de aceptar valores NULL.
        protected Truck(int id,int cWeight, bool full, int remainingC)
#pragma warning restore CS8618 // La instancia de propiedad "Container" que acepta valores NULL está sin inicializar. Considere la posibilidad de declarar la instancia de propiedad como capaz de aceptar valores NULL.
        {
            this.id = id;
            this.cWeight = cWeight;
            this.full = full;
            this.remainingC = remainingC;
            this.c = new List<Container>();

        }

        public int Id
        {
            get;set;
        }


        public int CWeight
        {
            get; set;
        }




        public bool SetContainer(Container con)
        {
            

            if (remainingC > 0)
            {

                    this.c.Add(con);

                    if (con.getRWeight() == 1500)
                    {
                        remainingC -= 2;
                    }
                    else
                    {
                        remainingC--;
                    }

                

            }
            if(remainingC == 0)
            {
                this.full = true;

            }

            return this.full;
        }

        public bool Full
        {
            get; set;
        }

        public override String ToString() {
            StringBuilder str = new StringBuilder();
            str.Append("ID: ").Append(this.id).Append("\n");

            if (this.cWeight == 1500) {
                str.Append("MAX WEIGHT ").Append((double)cWeight / 1000).Append("Tm").Append("\n");

            }
            else
            {
                str.Append("MAX WEIGHT ").Append(cWeight).Append("Kg").Append("\n");
            }

            str.Append("Is it full: ").Append(this.full).Append("\n");
            str.Append(" Slots to fill ").Append(this.remainingC).Append("\n");

            str.Append("Containers: ");
            foreach(var v in this.c)
            {
                str.Append(v.ToString());
            }
            str.Append("\n\n");

            return str.ToString();

        }

        


    }
}
