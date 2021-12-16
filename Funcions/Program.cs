using System;

namespace Funcions
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        //Delegat Func<int, int, int> definiuje że zmienna addOrSub powinna być funkcją
        //która przyjmuje pierwszy argument typu int, drugi argument typu int oraz zwraca int
        // na co wskazuje ostatni argument int.
        public int function(int a,int b, Func<int, int, int> addOrSub)
        {
            return addOrSub(a,b);
        }
    }
}
