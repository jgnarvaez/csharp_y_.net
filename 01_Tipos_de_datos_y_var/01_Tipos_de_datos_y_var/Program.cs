using System;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(String[] args)
        {
            //TIPOS DE DATOS DE NÚMEROS ENTEROS

            //(valores de 0 a 255) números positivos
            byte numero1 = 200;

            //(valores de -128 a 127) permite números negativos
            sbyte numero2 = -128;

            //(2 bytes) permite números positivos y negativos
            short numero3 = -200;

            //(2 bytes) solo números positivos
            ushort numero4 = 200;

            //(4 bytes) permite números positivos y negativos
            int numero5 = -300;

            //(4 bytes) solo números positivos
            uint numero6 = 500;

            //(8 bytes) permite números positivos y negativos
            long numero7 = -1000;

            //(8 bytes) solo números positivos
            ulong numero8 = 1000;

            //TIPOS DE DATOS DE NÚMEROS CON DECIMALES

            //(4 bytes)
            float numero9 = 15.2f;

            //(8 bytes) más alcance
            double numero10 = 9.2d;

            //(16 bytes) mucho más alcance
            decimal numero11 = 222.2m;

            //OTROS TIPOS DE DATOS

            //(2 bytes) una sola letra - comilla simple - cadena de caracter
            char variable1 = 'A';

            //boleano (true o false)
            bool variable2 = true;

            //TIPOS DE DATOS COMPUESTOS

            //comillas dobles - cadena
            string variable3 = "palabra";

            //Date time - clase - objeto - Fecha
            DateTime variable4 = DateTime.Now;
            Console.WriteLine(variable4);

            //se puede inicializar tipos de datos como objetos
            int numero12 = new int();
            Console.WriteLine(numero12.ToString());

            //para permitir nulos se agrega '?'
            int? numero13 = null;

            //var permite asignar valor y tipo a una variable
            var nombre = "Jose";
            var limite = 50;

            //creando un objeto anonimo con object
            object persona = new { nombre = "José", apellido = "Narváez" };
            Console.WriteLine(persona);

            //con var puedo acceder a los datos de mi objeto
            var persona2 = new { nombre = "José", apellido = "Narváez", edad = 50 };
            Console.WriteLine(persona2.edad);

        }
    }
}
