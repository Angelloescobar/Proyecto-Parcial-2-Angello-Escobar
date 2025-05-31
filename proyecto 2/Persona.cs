using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_2
{
    public class Persona
    {
        public Persona()
        {
        }

        //Propiedades
        public string Municipio { get; set; }
        public string cultivo { get; set; }
        public string terreno { get; set; }
        public DateTime fecha { get; set; }

        public Persona(string municipio, string cultivo, string terreno, DateTime fecha)
        {
            this.Municipio = municipio;
            this.cultivo = cultivo;
            this.terreno = terreno;
            this.fecha = fecha;
        }


    }

}
