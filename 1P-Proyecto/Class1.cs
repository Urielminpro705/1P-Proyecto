using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1P_Proyecto
{
    partial class Alimento
    {
        private int kilos;
        private String tipo;
        private double precio;

        public Alimento()
        {

        }

        public Alimento(int kilos, String tipo)
        {
            this.kilos = kilos;
            this.tipo = tipo;
        }

        public void calcularPrecio()
        {
            switch (this.tipo)
            {
                case "Estandar":
                    if (this.kilos == 1)
                    {
                        this.precio = 40;
                    }
                    else
                    {
                        if (this.kilos == 8)
                        {
                            this.precio = (40*0.93)*this.kilos;
                        }
                        else
                        {
                            if (this.kilos == 12)
                            {
                                this.precio = (40 * 0.87) * this.kilos;
                            }
                            else
                            {
                                if (this.kilos == 24)
                                {
                                    this.precio = (40 * 0.82) * this.kilos;
                                }
                            }
                        }
                    }
                    break;

                case "Intermedio":
                    break;

                case "Premium":
                    break;
            }
        }
    }
}
