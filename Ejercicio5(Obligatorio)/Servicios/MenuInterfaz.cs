using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Servicios
{
    /// <summary>
    /// interfaz que contiene todas las cabeceras del servicio menu
    /// 06/11/23 - sav
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra los diferentes opciones que tiene nuestro menu y que se escoja uno
        /// 06/11/23 - sav
        /// </summary>
        /// <returns></returns>
        public int Menu();

        /// <summary>
        /// Pide por pantalla y recoge un mes que se introduzca 
        /// 06/11/23
        /// </summary>
        /// <returns></returns>
        public int datoMes();

        /// <summary>
        /// Pide por pantalla y recoge un anyo que se introduzca 
        /// 06/11/23
        /// </summary>
        /// <returns></returns>
        public int datoAnyo();
    }
}
