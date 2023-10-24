using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Condi.servicios
{
    internal class operadorImplementacion : operadorInterfaz
    {
        public int PedirOperador()
        {
            int numero;

            Console.WriteLine("Introduce un número");
            numero = Int32.Parse(Console.ReadLine());

            return numero;
        }
    }
}
