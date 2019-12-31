using System;

namespace Enum_Enumeraciones_
{
    class Program
    {
        enum mes { Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre, Octubre, Noviembre, Diciembre};
        enum color{Rojo = 4 , Negro, Purpura};

        static void Main(string[] args)
        {

            int numero = 0;

            // Declarar una variable de tipo mes

            mes miMes;

            // Asignamos un valor

            miMes = mes.Mayo;

            //Pasamos de enumeracion a entero

            numero = (int)miMes;

            // Mostramos la informacion

            Console.WriteLine("El mes es{0}, con valor de:{1}", miMes, numero);

            // Creamos variable de tipo color

            color miColor = color.Negro;

            // Pasamos el valor a numero

            numero = (int)miColor;

            // Mostramos la informacion

            Console.WriteLine("El color es {0}, con valor de:{1}", miColor, numero);



            
        }
    }
}
