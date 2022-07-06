using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class queries {
        public string[] ordenamientoDesc(String[] nombres) {
            IEnumerable<string> result=from nombre in nombres
                                        orderby nombre descending
                                        select nombre;
            return result.ToArray();
        }
        public bool coincidencia(String[] nombres, String objetivo) {
            IEnumerable<string> result = from nombre in nombres
                                         where nombre == objetivo
                                         select nombre;
            if (result.Any()) {
                return true;
            }
            else
                return false;
        }

        public string[] empiezaCon(String[] nombres)
        {
            IEnumerable<string> result = from nombre in nombres
                                         where nombre.Contains("Juan")
                                         select nombre;
            return result.ToArray();
        }

        public string[] concatena(String[] nombres)
        {
            String [] result = new String[nombres.Length];
            for (int i = 0; i < result.Length; i++) {
                result[i] = "Hola " + nombres[i];
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nombres = { "Juan", "Pablo", "Pedro", "Pepe", "Ana", "Esteban", "Daniel", "Mariano", "Carolina", "Silvia", "Roberto", "Juanito", "Juana" };
            var query = new queries();
            String[] nombresDesc = query.ordenamientoDesc(nombres);
            String[] nombresJuan = query.empiezaCon(nombres);
            String[] holaNombres = query.concatena(nombres);

            foreach (String nombre in nombresDesc) {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("\nEscribe el nombre a buscar:");
            String objetivo=Console.ReadLine();
            Console.WriteLine("\n" + query.coincidencia(nombres, objetivo) +"\n");

            foreach (String nombre in nombresJuan)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("\n");

            foreach (String nombre in holaNombres)
            {
                Console.WriteLine(nombre);
            }

            Console.ReadKey();
        }
    }
}
