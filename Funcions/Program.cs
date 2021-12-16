using System;

namespace Funcions
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        //Delegat Func<int, int, int> definiuje że zmienna addOrSub powinna być funkcją
        //która przyjmuje pierwszy argument typu int, drugi argument typu int oraz zwraca int
        // na co wskazuje ostatni argument int.
        public static int Function(int a, int b, Func<int, int, int> addOrSub)
        {
            return addOrSub(a, b);
        }
        public static void Main(string[] args)
        {
            int var1 = 1_000;
            int var2 = 100;

            int result1 = Function(var1,var2, Add);
            Console.WriteLine("result1: " + result1);

            int result2 = Function(var1, var2, Sub);
            Console.WriteLine("result2: " + result2);
        }
    }
}
