using ejercicio1Condi.servicios;

namespace ejercicio1Condi.controladores
{
    class Program
    {
        internal static void Main(string[] args)
        {
            int numero;
            operadorInterfaz mi = new operadorImplementacion();

            numero = mi.PedirOperador();

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }

            else
            {
                Console.WriteLine("El número introducido es impar");
            }
        }
    }
}
