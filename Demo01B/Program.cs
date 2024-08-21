using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)

        {


            Persona persona = new Persona();
            persona.Nombres = "Cielo Jazmin";
            persona.Apellidos = "Espinoza Cortez";

            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);


            Console.WriteLine("hola Mundo");
            Console.Read();
        }
    }
}
