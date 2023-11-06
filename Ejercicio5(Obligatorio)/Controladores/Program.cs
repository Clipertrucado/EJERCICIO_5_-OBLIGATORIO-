using Ejercicio5.Servicios;

namespace Ejercicio5.Controladores {

    /// <summary>
    /// Clase principal del programa
    /// 06/11/2023 - sav
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicación
        /// 06/11/23 - sav
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //creamos dos objetos de los servicios que vamos a utilizar
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            //creamos un tipo bool para poder cerrar el while
            bool cerrarMenu = false;

            // este int sera el encargado de guardar el valor seleccionado en el menu
            int opcionSeleccionada;

            //crearemos un while para que nos mantenga en el menu siempre que no se diga lo contrario
            while (!cerrarMenu)
            {
                //llamamos al metodo menu 
                opcionSeleccionada = mi.Menu();


                Console.WriteLine(opcionSeleccionada);

                //compara la opcion seleccionada y entra en el casos correcto
                switch (opcionSeleccionada)
                {
                    //Este caso cerrara la aplicacion 
                    case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso uno 0");
                        cerrarMenu = true;
                        break;


                    //continen los pasos de esta opcion 
                    case 1:

                        //se llama al metodo datoMes
                        int mes = mi.datoMes();
                        //se llama al metod datoAnyo
                        int anyo = mi.datoAnyo();
                        //se llama al metod dias
                        op.dias(mes, anyo);

                        Console.WriteLine("");

                    break;

                    default:
                        
                    break;

                }

            }

        }

    }

}


    