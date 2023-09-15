using System;
 namespace Uppgift2._1 
{
 class Program 
    {
     static void Main(string[] args) 
        {
            Console.WriteLine("Vilken är din favoritbok?");
            string x = Console.ReadLine();
            Console.WriteLine("Din favorit bok är " + x);
            Console.ReadKey();
        }
    }
}