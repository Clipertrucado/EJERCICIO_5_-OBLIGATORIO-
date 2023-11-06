using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Servicios
{
    /// <summary>
    /// implementacion del as acciones del menu 
    /// 06/11/23 - sav
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int Menu()
        {
            //muestra los diferenctes casos que podremos ejecutar 
            Console.WriteLine("#######################################################");
            Console.WriteLine("      0. Cerrar aplicación");
            Console.WriteLine("      1. Saber cuando dias tiene un mes introducido");
            Console.WriteLine("#######################################################");

            //se recogera un solo caracter
            int opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            //devuelve le valor de opcionIntroducida
            return opcionIntroducida;
        }

        public int datoMes()
        {
            //se pide un mes
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("     Introduzca un mes de forma numérica");
            Console.WriteLine("_______________________________________________________");

            //se recoge el valor introducido 
            int dMes = Convert.ToInt32(Console.ReadLine());
            
            //se devuelve el valor de mes
            return dMes;
        }

        public int datoAnyo()
        {
            //se pide un anyo
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("     Introduzca un año de forma numérica");
            Console.WriteLine("_______________________________________________________");

            //se recoge el valor introducido 
            int dAnyo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("_______________________________________________________");

            //se devuelve el valor de anyo
            return dAnyo;
        }
    }
}
