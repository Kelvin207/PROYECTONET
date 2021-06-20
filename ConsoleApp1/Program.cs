using ConsoleApp1.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region POO
            /*
             = Asignación 
            == Comaración
            */
            /*
            ClienteBEAN cliBEAN = new ClienteBEAN();
            cliBEAN.Nombre = "Kelvin";
            cliBEAN.Apellido = "Palomino";
            cliBEAN.Edad = 27;
            cliBEAN.Genero = 'M';
            cliBEAN.Carrera = "Ing. Sistemas";

            //Console.WriteLine(cliBEAN.Nombre);
            Console.WriteLine(cliBEAN.ConcatenarDatos());
            Console.WriteLine(cliBEAN.ConcatenarDatosConParametros("Jose","Perez"));
            */
            #endregion


            #region Listas con u tipo de dato
            /* Coleccion de Datos
             Listas = List
             Diccionarios = Dictionary
             Colas = Queue
             Pilas = Stack
             */
            /*
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(40); // indice 0
            listaNumeros.Add(9); // indice 1
            listaNumeros.Add(10); // indice 2
            // inicialiacion; validacion; incremento
            Console.WriteLine("Lista de Números FOR");
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }

            Console.WriteLine("Listas de Números FOREACH");
            foreach (var item in listaNumeros)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region Lista de Datos
            //int numero = 0;
            //List<int> listaNum = new List<int>();
            //do
            //{
            //    Console.WriteLine("Ingrese número");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    listaNum.Add(numero);
            //} while (numero != 0);
            //Console.WriteLine("Lista de Numero INgresados");
            //foreach (var item in listaNum)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region
            //ClienteBEAN cliBEAN = new ClienteBEAN();
            //cliBEAN.Nombre = "Kelvin";
            //cliBEAN.Apellido = "Palomino";
            //ClienteBEAN cliBEAN2 = new ClienteBEAN() { Nombre = "Carlos", Apellido = "Perez" };
            //List<ClienteBEAN> listaCliente = new List<ClienteBEAN>();
            //listaCliente.Add(cliBEAN);
            //listaCliente.Add(cliBEAN2);
            //listaCliente.Add(new ClienteBEAN { Nombre = "Carol", Apellido = "Pariona" });

            //Console.WriteLine("Lista de Clientes");
            //foreach (var item in listaCliente)
            //{
            //    Console.WriteLine(item.Nombre + " " + item.Apellido);  
            //}

            #endregion
            #region Dictionary - Diccionario de Datos
            // Key - Value
            //Dictionary<int, string> datos = new Dictionary<int, string>();
            //datos.Add(1,"Lunes");
            //datos.Add(2,"Martes");
            //datos.Add(3,"Miercoles");
            //datos.Add(4,"Jueves");
            //datos.Add(5,"Viernes");
            //datos.Add(6,"Sábado");
            //datos.Add(7,"Domingo");

            //Console.WriteLine("Ingrese Valor: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El nombre del Día es: " + datos[valor]);

            #endregion
            #region
            //Dictionary<int, int> horaTrabajo = new Dictionary<int, int>();
            //horaTrabajo.Add(1, 10);
            //horaTrabajo.Add(2, 12);
            //horaTrabajo.Add(3, 15);

            //Console.WriteLine("Ingrese Horas Trabajadas:");
            //int valor_ingresado = Convert.ToInt32(Console.ReadLine());            
            //int Valor_total = 0;

            //Valor_total = valor_ingresado * 10;

            //if (valor_ingresado > 8 && valor_ingresado <= 11)
            //{
            //    Valor_total = Valor_total + (valor_ingresado - 8) * horaTrabajo[2];
            //}
            //if (valor_ingresado >= 12 && valor_ingresado <= 13)
            //{
            //    Valor_total = Valor_total + (valor_ingresado - 8) * horaTrabajo[3];
            //}

            //Console.WriteLine("EL valor ingresado es: " + valor_ingresado);
            //Console.WriteLine("las Horas Extras es: " + (valor_ingresado - 8));
            //Console.WriteLine("EL valor total es: " + Valor_total);
            #endregion
            #region ejercicio 1
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

            Console.WriteLine("Ingrese Horas Trabajadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            int horaExtra = 0;
            int costoHoraExtra = 0;
            int costodia = 0;
            if(horas > 8)
            {
                horaExtra = horas - 8;
                costoHoraExtra = listaHoraExtra[horaExtra] * horaExtra;
                costodia = 8 * listaHoraExtra[0];
            }
            else
            {
                costodia = horas * listaHoraExtra[0];
            }

            Console.WriteLine("Horas Trabajadas: " + horas);
            Console.WriteLine("Costo Horas Normales: " + costodia + " S/. ");
            Console.WriteLine("Horas Extras: " + horaExtra);
            Console.WriteLine("Costo Horas Extras: " + costoHoraExtra + " S/. ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Pago a realizar es de: " + (costodia + costoHoraExtra) + " S/. ");


            List<TrabajadorBEAN> listaTrabajador = new List<TrabajadorBEAN>();
            Console.WriteLine("Ingrese Datos del Trabajador: ");
            Console.WriteLine("Código: ");
            int Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombres: ");
            string Nombres = Convert.ToString(Console.ReadLine());

            listaTrabajador.Add(new TrabajadorBEAN { Codigo = Codigo, ApellidosNombres = Nombres, HorasTrabajo = horas, PagoTotal = (costodia + costoHoraExtra) });

            Console.WriteLine("Datos del Trabajador");
            foreach (var item in listaTrabajador)
            {
                Console.WriteLine("Codigo: " + item.Codigo);
                Console.WriteLine("Nombres: " + item.ApellidosNombres);
                Console.WriteLine("Horas de Trabajo: " + item.HorasTrabajo);
                Console.WriteLine("Pago Total: " + item.PagoTotal);
            }

            #endregion


            Console.ReadLine();
        }
    }
}
