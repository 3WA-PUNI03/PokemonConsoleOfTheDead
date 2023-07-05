using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetPowa
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            Pokemon pikachu = new Pokemon("pikachu", 50);
            Pokemon sangoku = new Pokemon("sangoku", 1000000);

            Console.WriteLine($"olala le {pikachu.Name} il a {pikachu.CurrentHp} point de vie");
            
            pikachu.Heal(200000);

            pikachu.Heal(-200);

            Console.WriteLine($"olala le {pikachu.Name} il a {pikachu.CurrentHp} point de vie");


            //Fight epicFight = new Fight(pikachu, sangoku);
            //epicFight.PlayRound();

            //int hp = pikachu._currentHp;  // pas le droit
            int hp = pikachu.CurrentHp; // On Get currentHealth
           

            Console.WriteLine($"olala le {pikachu.Name} il a {pikachu.CurrentHp} point de vie");

            Console.ReadKey();
        }
    }
}
