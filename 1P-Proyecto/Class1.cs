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

        public Alimento()
        {

        }

        public Alimento(int kilos, String tipo)
        {
            this.kilos = kilos;
            this.tipo = tipo;
        }
    }
}
