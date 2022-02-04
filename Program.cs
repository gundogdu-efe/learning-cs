using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*namespace FirstPorject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
            Console.ReadLine();
        }
    }
}
*/
namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Efe";

            int characterAge;
            characterAge = 23;
            Console.WriteLine("There once was a man named "+ characterName);
            Console.WriteLine("He was "+ characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the named "+ characterName);
            Console.WriteLine("But didn't like being "+ characterAge);
        }
    }
}