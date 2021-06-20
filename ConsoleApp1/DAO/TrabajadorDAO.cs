using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DAO
{
    public class TrabajadorDAO
    {
        public int CalculoHorasExtras(int horas)
        { 

            Dictionary<int, int> listaHoraExtra = new Dictionary<int, int>();
            listaHoraExtra.Add(0, 10);
            listaHoraExtra.Add(1, 12);
            listaHoraExtra.Add(2, 12);
            listaHoraExtra.Add(3, 12);
            listaHoraExtra.Add(4, 13);
            listaHoraExtra.Add(5, 13);
            listaHoraExtra.Add(6, 15);
            listaHoraExtra.Add(7, 15);
            listaHoraExtra.Add(8, 15);

            int resultado = 0;

            int horaExtra = 0;
            int costoHoraExtra = 0;
            int costodia = 0;
            if (horas > 8)
            {
                horaExtra = horas - 8;
                costoHoraExtra = listaHoraExtra[horaExtra] * horaExtra;
                costodia = 8 * listaHoraExtra[0];
            }
            else
            {
                costodia = horas * listaHoraExtra[0];
            }

            resultado = costodia + costoHoraExtra;
            return resultado;
        }

    }
}
