using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolakPetersFlyingAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird kiwi = new KiwiBird();
            Bird black = new BlackBird();
            Console.WriteLine(kiwi.Draw());
            Console.WriteLine(black.Draw());
            Console.ReadKey();
        }
    }
}
