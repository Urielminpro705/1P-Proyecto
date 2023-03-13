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
                    break;

                case "Intermedio":
                    break;

                case "Premium":
                    break;
            }
        }
    }
}
