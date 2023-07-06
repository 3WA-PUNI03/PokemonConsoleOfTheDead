using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ObjetPowa
{
    internal class Fight
    {
        // Champs / Field
        private Pokemon _player;
        private Pokemon _enemy;

        // Constructeur / Constructor
        public Fight(Pokemon player, Pokemon enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        // Méthodes / Methodes
        public void PlayRound(CharacterChoice playerChoice, CharacterChoice enemyChoice)
        {
            if (_player.Speed > _enemy.Speed)
            {
                // Player attack
                PokemonTurn(playerChoice, _player, _enemy);

                if (_enemy.IsDead() == false)
                {
                    // Enemy attack
                    PokemonTurn(enemyChoice, _enemy, _player);
                }
            }
            else
            {
                // Enemy attack
                PokemonTurn(enemyChoice, _enemy, _player);

                if (_player.IsDead() == false)
                {
                    // Player attack
                    PokemonTurn(playerChoice, _player, _enemy);
                }
            }
        }

        private void PokemonTurn(CharacterChoice choice, Pokemon main, Pokemon opponent)
        {
            switch (choice)
            {
                case CharacterChoice.Attack:

                    opponent.Damage(main);

                    break;
                case CharacterChoice.Heal:
                    main.Heal(PotionType.Potion);
                    break;
                default:
                    break;
            }
        }

        public bool IsFightFinished()
        {
            if (_player.IsDead() || _enemy.IsDead())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
