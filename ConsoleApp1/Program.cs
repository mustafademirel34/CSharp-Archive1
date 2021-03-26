using System;

namespace ConsoleApp1
{
    class Program : deneme
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            test();
        }

        static void test()
        {
            test();
        }
    }

    abstract class deneme
    {
        internal virtual void a1() { }
        internal virtual void a2() { }

        internal virtual void test()
        {
            Console.WriteLine("1");

            a1();

            Console.WriteLine("2");
        }
    }


}
