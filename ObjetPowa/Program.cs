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
            Pokemon salameche = new Pokemon("salameche", 40, 100, 50, 30, PokemonType.Fire);
            Pokemon bulbizarre = new Pokemon("bulbizarre", 200, 90, 40, 30, PokemonType.Plant);
            Fight epicFight = new Fight(salameche, bulbizarre);

            do
            {
                // Choix du joueur      // INPUT
                CharacterChoice playerChoice = GetPlayerChoice(salameche);

                // Choix de l'IA
                CharacterChoice randomChoice = AIChoice(bulbizarre);

                // Met à jour le combat     // UPDATE
                epicFight.PlayRound(playerChoice, randomChoice);

                // Affiche la situation du jeu      // DRAW
                DrawFight(salameche, bulbizarre);

            } while (epicFight.IsFightFinished() == false);

            // Resultat final
            if (salameche.IsDead() && bulbizarre.IsDead())
            {
                Console.WriteLine($"Draw");
            }
            else if (salameche.IsDead())
            {
                Console.WriteLine($"{bulbizarre.Name} winner");
            }
            else
            {
                Console.WriteLine($"{salameche.Name} winner");
            }

            Console.ReadKey();
        }

        private static void DrawFight(Pokemon pikachu, Pokemon sangoku)
        {
            Console.WriteLine($"{pikachu.Name} : {pikachu.CurrentHp} / {pikachu.HpMax}");
            Console.WriteLine($"{sangoku.Name} : {sangoku.CurrentHp} / {sangoku.HpMax}");
        }

        private static CharacterChoice AIChoice(Pokemon ai)
        {
            if(ai.PotionCount <= 0)
            {
                return CharacterChoice.Attack;
            }


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

        private static CharacterChoice GetPlayerChoice(Pokemon player)
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

                        if(player.PotionCount > 0)
                        {
                            playerChoice = CharacterChoice.Heal;
                        }
                        else
                        {
                            Console.WriteLine("Nop noob");
                        }

                        break;
                    default:
                        break;
                }
            } while (playerChoice == CharacterChoice.None);
            return playerChoice;
        }
    }
}
