using System;
using System.Collections.Generic;
using System.Text;

namespace DocksGestionApp.Core.Shipment
{
    class Ship
    {
        List<Container> cargo;
        int bigNum;
        int smallNum;

#pragma warning disable CS8618 // La instancia de propiedad "Cargo" que acepta valores NULL está sin inicializar. Considere la posibilidad de declarar la instancia de propiedad como capaz de aceptar valores NULL.
        public Ship()
#pragma warning restore CS8618 // La instancia de propiedad "Cargo" que acepta valores NULL está sin inicializar. Considere la posibilidad de declarar la instancia de propiedad como capaz de aceptar valores NULL.
        {
            cargo = new List<Container>();
            bigNum = 0;
            smallNum = 0;
           
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



        private void IncNum(Container c)
        {

            if (c.getRWeight() == 1500)
            {
                bigNum++;
            }
            else
            {
                smallNum++;
            }
        }


        public void Add(Container c)
        {
            cargo.Add(c);
            IncNum(c);

        }

        public void Delete(Container c)
        {
            if(cargo.Remove(c))
            {
                if (c.getRWeight() == 1500)
                {
                    bigNum--;
                }
                else
                {
                    smallNum--;
                }
            }

        }

        public List<Container> Cargo
        {
            get;set;
        }

        public void Add(Container[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                this.Add(t[i]);

            }
        }

        public void Delete(Container[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                this.Delete(t[i]);

            }
        }

        public List<Container> GetContainers(int num)
        {
            List<Container> freeOnes = new List<Container>();

            foreach (Container c in cargo)
            {
                if (!c.getDeployed())
                {
                   if(c.getRWeight()==1500 && num == 0)
                    {
                        freeOnes.Add(c);
                    }
                    else if(c.getRWeight() == 800 && num ==1)
                    {
                        freeOnes.Add(c);
                    }
                }
            }
            return freeOnes;
        }



        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

           foreach(var c in cargo)
            {
                str.Append(c.ToString());
            }

            return str.ToString();
        }
    }

    

}

