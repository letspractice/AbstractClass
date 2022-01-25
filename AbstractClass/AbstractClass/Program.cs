using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trying Abstract classes/methods");
            Instagram instagram = new Instagram();
            instagram.Print();

            Newspaper newspaper = new Newspaper();
            newspaper.Print();
        }
    }
}
