﻿using System;
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
                        this.precioDescuento = precio;
                    }
                    else
                    {
                        if (this.kilos == 8)
                        {
                            this.precioDescuento = (this.precio*0.93)*this.kilos;
                        }
                        else
                        {
                            if (this.kilos == 12)
                            {
                                this.precioDescuento = (this.precio * 0.87) * this.kilos;
                            }
                            else
                            {
                                if (this.kilos == 24)
                                {
                                    this.precioDescuento = (this.precio * 0.82) * this.kilos;
                                }
                            }
                        }
                    }
                    break;

                case "Intermedio":

                    this.precio = 52;
                    if (this.kilos == 1)
                    {
                        this.precioDescuento = precio;
                    }
                    else
                    {
                        if (this.kilos == 8)
                        {
                            this.precioDescuento = (this.precio * 0.93) * this.kilos;
                        }
                        else
                        {
                            if (this.kilos == 12)
                            {
                                this.precioDescuento = (this.precio * 0.87) * this.kilos;
                            }
                            else
                            {
                                if (this.kilos == 24)
                                {
                                    this.precioDescuento = (this.precio * 0.82) * this.kilos;
                                }
                            }
                        }
                    }
                    break;


                case "Premium":

                    this.precio = 65;
                    if (this.kilos == 1)
                    {
                        this.precioDescuento = precio;
                    }
                    else
                    {
                        if (this.kilos == 8)
                        {
                            this.precioDescuento = (this.precio * 0.93) * this.kilos;
                        }
                        else
                        {
                            if (this.kilos == 12)
                            {
                                this.precioDescuento = (this.precio * 0.87) * this.kilos;
                            }
                            else
                            {
                                if (this.kilos == 24)
                                {
                                    this.precioDescuento = (this.precio * 0.82) * this.kilos;
                                }
                            }
                        }
                    }

                    break;
            }
        }
    }
}
