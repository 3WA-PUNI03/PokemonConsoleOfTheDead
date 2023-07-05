using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ObjetPowa
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            Pokemon pikachu = new Pokemon("pikachu", 40);
            Pokemon sangoku = new Pokemon("sangoku", 50);
            Fight epicFight = new Fight(pikachu, sangoku);

            //pikachu.Damage(10000);
            //pikachu.Resurection(RappelType.Basique);
            //pikachu.Heal(PotionType.HyperPotion);

            do
            {
                // Choix du joueur      // INPUT
                //Console.WriteLine("Action du joueur 1-attack/2-potion");
                //string response = Console.ReadLine();


                // Met à jour le combat     // UPDATE
                int r = new Random().Next(1, 100);
                CharacterChoice randomChoice;
                //randomChoice = (CharacterChoice) r;       <=== Cast un int en CharacterChoice
                if (r < 90)
                {
                    randomChoice = CharacterChoice.Attack;
                }
                else
                {
                    randomChoice = CharacterChoice.Heal;
                }

                epicFight.PlayRound(CharacterChoice.Attack, randomChoice);


                // Affiche la situation du jeu      // DRAW
                Console.WriteLine($"{pikachu.Name} : {pikachu.CurrentHp} / {pikachu.HpMax}");
                Console.WriteLine($"{sangoku.Name} : {sangoku.CurrentHp} / {sangoku.HpMax}");

            } while (epicFight.IsFightFinished() == false);

            // Resultat final
            if(pikachu.IsDead() && sangoku.IsDead() ) 
            {
                Console.WriteLine($"Draw");
            }
            else if(pikachu.IsDead())
            {
                Console.WriteLine($"{sangoku.Name} winner");
            }
            else
            {
                Console.WriteLine($"{pikachu.Name} winner");
            }



            Console.ReadKey();
        }
    }
}
