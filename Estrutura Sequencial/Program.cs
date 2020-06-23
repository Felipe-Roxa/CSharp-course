using System;
using System.Runtime.InteropServices;

namespace Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("SOMA = " + (a + b));
            //

            //double r = double.Parse(Console.ReadLine());

            //Console.WriteLine("A=" + (3.14159*Math.Pow(r, 2)).ToString("F4"));
            //

            //String[] v = Console.ReadLine().Split(' ');
            //int a = int.Parse(v[0]);
            //int b = int.Parse(v[1]);
            //int c = int.Parse(v[2]);
            //int d = int.Parse(v[3]);

            //int dif = (a * b) - (c * d);

            //Console.WriteLine("DIFERENCA = " + dif);
            //

            //int nf = int.Parse(Console.ReadLine());
            //int nh = int.Parse(Console.ReadLine());
            //float vh = float.Parse(Console.ReadLine());

            //Console.WriteLine("NUMBER = " + nf.ToString() + "\nSALARY = R$ " + (nh*vh).ToString("F2"));
            //

            //String[] v = Console.ReadLine().Split(' ');
            //int cd1 = int.Parse(v[0]);
            //int np1 = int.Parse(v[1]);
            //float vu1 = float.Parse(v[2]);

            //String[] u = Console.ReadLine().Split(' ');
            //int cd2 = int.Parse(u[0]);
            //int np2 = int.Parse(u[1]);
            //float vu2 = float.Parse(u[2]);

            //Console.WriteLine("VALOR A PAGAR: R$ " + ((np1 * vu1) + (np2 * vu2)).ToString("F2"));
            //

            String[] v = Console.ReadLine().Split(' ');
            double a = double.Parse(v[0]);
            double b = double.Parse(v[1]);
            double c = double.Parse(v[2]);

            Console.WriteLine("TRIANGULO: " + (a * c / 2).ToString("F3"));
            Console.WriteLine("CIRCULO: " + (3.14159*Math.Pow(c, 2)).ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + ((a + b)*c/2).ToString("F3"));
            Console.WriteLine("QUADRADO: " + (Math.Pow(b, 2)).ToString("F3"));
            Console.WriteLine("RETANGULO: " + (a * b).ToString("F3"));
 
        }
    }
}
