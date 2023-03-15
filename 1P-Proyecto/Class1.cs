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
        private double precioDescuento;
        private int cantidad;

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

                    this.precio = 40;
                    if (this.kilos == 1)
                    {
                        this.precioDescuento = this.precio * this.cantidad;
                    }
                    else
                    {
                        if (this.kilos == 8)
                        {
                            this.precioDescuento = (this.precio*0.93)*this.kilos*this.cantidad;
                        }
                        else
                        {
                            if (this.kilos == 12)
                            {
                                this.precioDescuento = (this.precio * 0.87) * this.kilos * this.cantidad;
                            }
                            else
                            {
                                if (this.kilos == 24)
                                {
                                    this.precioDescuento = (this.precio * 0.82) * this.kilos * this.cantidad;
                                }
                            }
                        }
                    }
                    break;

                case "Intermedio":

                    this.precio = 52;
                    if (this.kilos == 1)
                    {
                        this.precioDescuento = this.precio * this.cantidad;
                    }
                    else
                    {
                        if (this.kilos == 8)
                        {
                            this.precioDescuento = (this.precio * 0.93) * this.kilos * this.cantidad;
                        }
                        else
                        {
                            if (this.kilos == 12)
                            {
                                this.precioDescuento = (this.precio * 0.87) * this.kilos * this.cantidad;
                            }
                            else
                            {
                                if (this.kilos == 24)
                                {
                                    this.precioDescuento = (this.precio * 0.82) * this.kilos * this.cantidad;
                                }
                            }
                        }
                    }
                    break;


                case "Premium":

                    this.precio = 65;
                    if (this.kilos == 1)
                    {
                        this.precioDescuento = this.precio * this.cantidad;
                    }
                    else
                    {
                        if (this.kilos == 8)
                        {
                            this.precioDescuento = (this.precio * 0.93) * this.kilos * this.cantidad;
                        }
                        else
                        {
                            if (this.kilos == 12)
                            {
                                this.precioDescuento = (this.precio * 0.87) * this.kilos * this.cantidad;
                            }
                            else
                            {
                                if (this.kilos == 24)
                                {
                                    this.precioDescuento = (this.precio * 0.82) * this.kilos * this.cantidad;
                                }
                            }
                        }
                    }

                    break;
            }
        }


        public int getKilos()
        {
            return this.kilos;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public String getTipo()
        {
            return this.tipo;
        }

        public double getPrecio()
        {
            return this.precio;
        }

        public double getPrecioDescuento()
        {
            return this.precioDescuento;
        }

        public void setKilos(int kilos)
        {
            this.kilos = kilos;
        }

        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
    }
}
