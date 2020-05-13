using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber(Guid.NewGuid(), pub);

            pub.Update();

            Console.ReadLine();
        }
    }
}
