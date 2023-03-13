using System;
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
            int opcion=-1, pos = 1, opcion2=0;
            do
            {
                try
                {
                    opcion = menu();
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

                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nLas letras no son validas, vuelve a intentar\n");
                                }

                            } while (opcion2!=4);
                            
                            break;

                        case 2:
                            break;

                        case 3:
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
                
                
            } while (opcion!=3);
        }

        public static int menu()
        {
            int opcion;
            Console.WriteLine("--Elige una opcion--");
            Console.WriteLine("1) Agregar una compra al pedido");
            Console.WriteLine("2) Ver total del pedido");
            Console.WriteLine("3) Confirmar pedido");
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

        public static void leerDatos(int pos)
        {
            for(int i = 0; i < pos; i++)
            {

            }
        }
    }
}
