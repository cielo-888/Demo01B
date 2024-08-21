using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Persona
    {
       
        public int Nombres { get; set; }
        public int Apellidos { get; set; }

        public int Edad { get; set; }
        public string NombresCompletos { get; set; }

        public string CalcularEdad()
       
        {
            string mensaje = "Es menor de edad";
            if (Edad > 18)
                mensaje = "Es mayor de edad";
            return mensaje;

        }

        


        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
            
    }
}
