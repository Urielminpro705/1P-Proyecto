﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1P_Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alimento[] a = new Alimento[50];
            int opcion = -1, pos = 0, opcion2 = 0, opcion3 = 0, opcion4 = 0, cantidad = 0; ;
            double total=0;
            do
            {
                opcion2 = 0;
                opcion3 = 0;
                opcion4 = 0;
                try
                {
                    opcion = menu(pos);
                    switch (opcion)
                    {
                        case 1:
                            do
                            {
                                try
                                {

                                    opcion2 = menuTipo();
                                    switch (opcion2)
                                    {
                                        case 1:
                                            do
                                            {
                                                try
                                                {

                                                    opcion3 = menuTamaño();
                                                    switch (opcion3)
                                                    {
                                                        case 1:
                                                            
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Estandar");
                                                            a[pos].setKilos(1);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 2:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Estandar");
                                                            a[pos].setKilos(8);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 3:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Estandar");
                                                            a[pos].setKilos(12);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 4:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Estandar");
                                                            a[pos].setKilos(24);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 5:
                                                            break;

                                                        default:
                                                            if (opcion3 < 1 || opcion3 > 5)
                                                            {
                                                                Console.WriteLine("\nEl numero no es una opcion valida\n");
                                                            }
                                                            break;
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    Console.WriteLine("\nLas letras no son validas, vuelve a intentar\n");
                                                }

                                            } while (opcion3 != 5);
                                            opcion2 = 4;
                                            break;

                                        case 2:
                                            do
                                            {
                                                try
                                                {

                                                    opcion3 = menuTamaño();
                                                    switch (opcion3)
                                                    {
                                                        case 1:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Intermedio");
                                                            a[pos].setKilos(1);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 2:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Intermedio");
                                                            a[pos].setKilos(8);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 3:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Intermedio");
                                                            a[pos].setKilos(12);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 4:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Intermedio");
                                                            a[pos].setKilos(24);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 5:
                                                            break;

                                                        default:
                                                            if (opcion3 < 1 || opcion3 > 5)
                                                            {
                                                                Console.WriteLine("\nEl numero no es una opcion valida\n");
                                                            }
                                                            break;
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    Console.WriteLine("\nLas letras no son validas, vuelve a intentar\n");
                                                }

                                            } while (opcion3 != 5);
                                            opcion2 = 4;
                                            break;

                                        case 3:
                                            do
                                            {
                                                try
                                                {

                                                    opcion3 = menuTamaño();
                                                    switch (opcion3)
                                                    {
                                                        case 1:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Premium");
                                                            a[pos].setKilos(1);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 2:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Premium");
                                                            a[pos].setKilos(8);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 3:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Premium");
                                                            a[pos].setKilos(12);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 4:
                                                            a[pos] = new Alimento();
                                                            a[pos].setCantidad(pedirCantidad());
                                                            a[pos].setTipo("Premium");
                                                            a[pos].setKilos(24);
                                                            a[pos].calcularPrecio();
                                                            pos++;
                                                            opcion3 = 5;
                                                            break;

                                                        case 5:
                                                            break;

                                                        default:
                                                            if (opcion3 < 1 || opcion3 > 5)
                                                            {
                                                                Console.WriteLine("\nEl numero no es una opcion valida\n");
                                                            }
                                                            break;
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    Console.WriteLine("\nLas letras no son validas, vuelve a intentar\n");
                                                }

                                            } while (opcion3 != 5);
                                            opcion2 = 4;
                                            break;

                                        default:
                                            if (opcion2 < 1 || opcion2 > 4)
                                            {
                                                Console.WriteLine("\nEl numero no es una opcion valida\n");
                                            }
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nLas letras no son validas, vuelve a intentar\n");
                                }

                            } while (opcion2!=4);
                            total = calcularTotal(a, pos);
                            break;

                        case 2:
                            
                            imprimirDatos(pos, a, total);
                            break;

                        case 3:                           
                            do
                            {
                                try
                                {
                                    opcion4 = menuConfirmacion(pos, total);
                                    switch (opcion4)
                                    {
                                        case 1:
                                            Console.WriteLine("\nVuelva pronto");
                                            opcion4 = 1;
                                            break;

                                        case 2:
                                            opcion4 = 2;
                                            break;

                                        default:
                                            Console.WriteLine("El numero no es valido");
                                            break;

                                    }

                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nLas letras no son validas, vuelve a intentar\n");
                                }

                            }while (opcion4 != 1 && opcion4!=2);
                            break;

                        default: 
                            if(opcion<1 || opcion > 3)
                            {
                                Console.WriteLine("\nEl numero no es una opcion valida\n");
                            }
                            break;

                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("\nLas letras no son validas, vuelve a intentar\n");
                }
                
                
            } while (opcion4!=1);
        }

        public static int pedirCantidad()
        {
            int cantidad;
            Console.WriteLine("Introduce el numero de bolsas de este articulo");
            cantidad=int.Parse(Console.ReadLine());
            return cantidad;
        }

        public static int menu(int pos)
        {
            int opcion;
            Console.WriteLine("\n--------Elige una opcion--------");
            Console.WriteLine("1) Agregar una compra al pedido");
            Console.WriteLine("2) Ver total del pedido");
            Console.WriteLine("3) Confirmar pedido ({0} pedidos)",pos);
            opcion=int.Parse(Console.ReadLine());
            return opcion;
        }

        public static int menuConfirmacion(int pos, double total)
        {
            int opcion; 
            Console.WriteLine("\n---Confirmacion---");
            Console.WriteLine("¿Quieres confirmar el pedido?");
            Console.WriteLine("{0} pedidos con un total de {1}",pos,total);
            Console.WriteLine("1) Confirmar");
            Console.WriteLine("2) Seguir comprando");
            opcion=int.Parse(Console.ReadLine());
            return opcion;
        }

        public static int menuTipo()
        {
            int opcion;
            Console.WriteLine("--Elige un tipo de grado alimenticio--");
            Console.WriteLine("1) Estandar");
            Console.WriteLine("2) Intermedio");
            Console.WriteLine("3) Premium");
            Console.WriteLine("\n4) --Regresar--");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        public static int menuTamaño()
        {
            int opcion;
            Console.WriteLine("--Elige una opcion--");
            Console.WriteLine("1) 1 kg");
            Console.WriteLine("2) 8 kg");
            Console.WriteLine("3) 12 kg");
            Console.WriteLine("4) 24 kg");
            Console.WriteLine("\n5) --Regresar--");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        public static void imprimirDatos (int pos, Alimento[] a, double total)
        {
            Console.WriteLine("\nCantidad\tGrado alimenticio\tKilos\tPrecio por kilo\t\tPrecio total con descuento");
            for (int i = 0; i < pos; i++)
            {
                Console.Write(a[i].getCantidad() + "  \t\t");
                Console.Write(a[i].getTipo() + "  \t\t");
                Console.Write(a[i].getKilos() + "\t\t");
                Console.Write(a[i].getPrecio() + "\t\t");
                Console.WriteLine("\t" + a[i].getPrecioDescuento() + "\n");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Precio total del pedido: " + total+"\n");
        }

        public static double calcularTotal(Alimento[] a, int pos)
        {
            double total=0;
            for (int i=0; i<pos;i++)
            {
                total = total + a[i].getPrecioDescuento();
            }
            return total;
        }
    }
}
