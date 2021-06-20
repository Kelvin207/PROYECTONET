using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BEAN
{
    public class ClienteBEAN
    {
        //uso del profull
        //uso del prop

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        private char genero;

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Carrera { get; set; }

        public string ConcatenarDatos()
        {
            string concatenado = "";
            concatenado = Nombre + ", " + Apellido;
            return concatenado;
        }

        public string ConcatenarDatosConParametros(string pNombre, string pApellido)
        {
            string concatenado = "";
            concatenado = pNombre + ", " + pApellido;
            return concatenado;
        }

    }
}
