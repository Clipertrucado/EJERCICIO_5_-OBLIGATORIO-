using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void dias(int mes, int anyo)
        {
            //todos los anios bisiestos son divisibles entre 4
            if (anyo % 4 == 0)
            {
                // si los son de 4 no lo son de 100 es bisiesto
                if (anyo % 100 != 0)
                {
                    //se llama al metodo bisiesto
                    bisiesto(mes);

                }
                //si lo es de 4 pero tambien de 100 no lo sera de 400 es bisiesto
                else if (anyo % 100 == 0 && anyo % 400 == 0)
                {
                    //se llama al metodo bisiesto
                    bisiesto(mes);

                }
                //si lo es de 4, 100 y 400 no sera bisiesto
                else
                {

                    //se llama al metodo noBisiesto
                    noBisiesto(mes);

                }

            }
            //si no es dividsible entre 4 no es visiesto 
            else
            {
                //se llama al metodo noBisiesto
                noBisiesto(mes);

            }

        }

        /// <summary>
        /// este metodo sera el encargado de mostrar por pantalla los dias de ese mes si el año no es bisiesto
        /// 06/11/23 - sav
        /// </summary>
        /// <param name="mes"></param>
        public void noBisiesto(int mes) 
        {
            //este if compara la variable que se le a pasado "mes" con el mes numerico de aquellos que tienen 31 dias
            if (mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 8 | mes == 10 | mes == 12)
            {
                Console.WriteLine("Este año no es bisiesto.");
                Console.WriteLine("Este mes cuenta con 31.");


            }
            //este if compara la variable que se le a pasado "mes" con el mes que se ve afectado si el anuy es o no bisiesto
            //que de forma numeria es "2" y como es le caso Bisiesto este mes tiene 28 dias
            else if (mes == 2)
            {
                //28
                Console.WriteLine("Este año no es bisiesto.");
                Console.WriteLine("Este mes cuenta con 28.");
            }
            //como solo hay tres tipos de meses; de 31 dias, que ya se ha comparado, de 28/29 dias, que ya se ha comparado y los meses de 30 dias
            //al no ser ni del primer ni segundo tipo tinen que serlo del tercero, entonces todos lo que entren aqui tendran 30 dias
            else
            {
                //30
                Console.WriteLine("Este año no es bisiesto.");
                Console.WriteLine("Este mes cuenta con 30.");
            }

            

        }

        /// <summary>
        /// este metodo sera el encargado de mostrar por pantalla los dias de ese mes si el año es bisiesto
        /// 06/11/23 - sav
        /// </summary>
        /// <param name="mes"></param>
        public void bisiesto(int mes) 
        {
            //este if compara la variable que se le a pasado "mes" con el mes numerico de aquellos que tienen 31 dias
            if (mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 8 | mes == 10 | mes == 12)
            {
            //31
                Console.WriteLine("Este año es bisiesto.");
                Console.WriteLine("Este mes cuenta con 31.");

            }
            //este if compara la variable que se le a pasado "mes" con el mes que se ve afectado si el anuy es o no bisiesto
            //que de forma numeria es "2" y como es le caso Bisiesto este mes tiene 28 dias
            else if (mes == 2)
            {
            //28
                Console.WriteLine("Este año es bisiesto.");
                Console.WriteLine("Este mes cuenta con 29.");
            }
            //como solo hay tres tipos de meses; de 31 dias, que ya se ha comparado, de 28/29 dias, que ya se ha comparado y los meses de 30 dias
            //al no ser ni del primer ni segundo tipo tinen que serlo del tercero, entonces todos lo que entren aqui tendran 30 dias
            else
            {
            //30
                Console.WriteLine("Este año es bisiesto.");
                Console.WriteLine("Este mes cuenta con 30.");

            }
        }

    }
}
