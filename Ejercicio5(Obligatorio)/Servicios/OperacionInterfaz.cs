using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Servicios
{
    /// <summary>
    /// interfaz que contiene todas las cabeceras del servicio operacion
    /// 06/11/23 - sav
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// este metodo necesitas los valores de mes y anyo y es el encargado de calcular si el año introducido es bisiesteo o no.
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="anyo"></param>
        public void dias(int mes, int anyo);


    }
}
