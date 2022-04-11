using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_alternativa = 0;
            


                

            do
            {

                Console.WriteLine("-----ALTERNATIVAS-----");

                Console.WriteLine("[1]. OPERACION");

                Console.WriteLine("[2]. SALIR");

                


                Console.WriteLine("Ingrese una opcíon: ");
                n_alternativa = int.Parse(Console.ReadLine());

                switch (n_alternativa)
                {


                    case 1:

                        int n1, n2;

                        OP x1, x2;

                        Console.WriteLine("Ingresar Dolares: ");
                        n1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar Soles:");
                        n2 = int.Parse(Console.ReadLine());


                        x1 = new OP(n1);

                        x2 = new OP(n2);


                        Console.WriteLine("El resultado de la suma es: {0}", x1 + x2);

                        Console.WriteLine("El resultado de la resta es: {0}", x1 - x2);

                        break;

                                

                }
               

            } while (n_alternativa != 2);




            Console.ReadKey();
        }
    }
}
