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
            Pokemon pikachu = new Pokemon("pikachu", 40, 100, 50, 30);
            Pokemon sangoku = new Pokemon("sangoku", 50, 90, 40, 30);


            for (int i = 0; i < 100; i++)
            {
                pikachu.Damage(sangoku);
            }

            Console.ReadKey();



#if false
            Console.WriteLine("Hello World");

            Fight epicFight = new Fight(pikachu, sangoku);

            //pikachu.Damage(10000);
            //pikachu.Resurection(RappelType.Basique);
            //pikachu.Heal(PotionType.HyperPotion);
            do
            {
                // Choix du joueur      // INPUT
                CharacterChoice playerChoice = GetPlayerChoice();

                // Choix de l'IA
                CharacterChoice randomChoice = AIChoice();

                // Met à jour le combat     // UPDATE
                epicFight.PlayRound(playerChoice, randomChoice);

                // Affiche la situation du jeu      // DRAW
                DrawFight(pikachu, sangoku);

            } while (epicFight.IsFightFinished() == false);

            // Resultat final
            if (pikachu.IsDead() && sangoku.IsDead())
            {
                Console.WriteLine($"Draw");
            }
            else if (pikachu.IsDead())
            {
                Console.WriteLine($"{sangoku.Name} winner");
            }
            else
            {
                Console.WriteLine($"{pikachu.Name} winner");
            }

            Console.ReadKey();
#endif
        }

        private static void DrawFight(Pokemon pikachu, Pokemon sangoku)
        {
            Console.WriteLine($"{pikachu.Name} : {pikachu.CurrentHp} / {pikachu.HpMax}");
            Console.WriteLine($"{sangoku.Name} : {sangoku.CurrentHp} / {sangoku.HpMax}");
        }

        private static CharacterChoice AIChoice()
        {
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

            return randomChoice;
        }

        private static CharacterChoice GetPlayerChoice()
        {
            CharacterChoice playerChoice = CharacterChoice.None;
            do
            {
                Console.WriteLine("Action du joueur 1-attack/2-potion");
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        playerChoice = CharacterChoice.Attack;
                        break;
                    case "2":
                        playerChoice = CharacterChoice.Heal;
                        break;
                    default:
                        break;
                }
            } while (playerChoice == CharacterChoice.None);
            return playerChoice;
        }
    }
}
