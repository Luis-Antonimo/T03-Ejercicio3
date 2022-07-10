using System;

namespace T03Ejercicio3
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 20;
            double n = 30.78;
            double m = -23.67;
            //Variable para realizar el doble de cada variable
            int d = 2;
            Console.WriteLine("Variable X = {0}", x);
            Console.WriteLine("Variable Y = {0}", y);
            Console.WriteLine("Variable N = {0}", n);
            Console.WriteLine("Variable M = {0}", m);
            Console.WriteLine("Suma X+Y = {0}", x + y);
            Console.WriteLine("Diferencia X-Y = {0}", x - y);
            Console.WriteLine("Producto X*Y = {0}", x * y);
            Console.WriteLine("Cociente X/Y = {0}", x / y);
            Console.WriteLine("Resto X%Y = {0}", x % y);
            Console.WriteLine("Suma N+M = {0}", n + m);
            Console.WriteLine("Diferencia N-M = {0}", n - m);
            Console.WriteLine("Producto N*M = {0}", n * m);
            Console.WriteLine("Copciente N/M = {0}", n / m);
            Console.WriteLine("Resto N%M = {0}", n % m);
            Console.WriteLine("Suma X+N = {0}", x + n);
            Console.WriteLine("Cociente Y/M = {0}", y / m);
            Console.WriteLine("Resto Y%M = {0}", y % m);
            Console.WriteLine("Doble de x= {0}, doble de y= {1}, doble de n= {2}, doble de m= {3}", x *= d, y *= d, n *= d, m *= d);
            Console.WriteLine("Suma de todas las variables = {0}", x + y + n + m);
            Console.WriteLine("El producto de todas las variables = {0}", x * y * n * m);
        }
    }
}