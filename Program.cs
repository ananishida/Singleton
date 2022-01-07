using System;

namespace Sigleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singleton s1 = Singleton.getInstance();
            Console.WriteLine(Singleton.nome);

            Singleton s2 = Singleton.getInstance();
            // Console.WriteLine(Singleton.nome);

            if (s1==s2)
            {
                Console.WriteLine("As instancias são iguais!");
            }
        }
    }
}
