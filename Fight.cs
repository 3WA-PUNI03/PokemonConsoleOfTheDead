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
            // Player attack
            switch (playerChoice)
            {
                case CharacterChoice.Attack:
                    _enemy.Damage(10);
                    break;
                case CharacterChoice.Heal:
                    _player.Heal(PotionType.Potion);
                    break;
                default:
                    break;
            }

            // Enemy attack
            switch (enemyChoice)
            {
                case CharacterChoice.Attack:
                    _player.Damage(10);
                    break;
                case CharacterChoice.Heal:
                    _enemy.Heal(PotionType.Potion);
                    break;
                default:
                    break;
            }
        }

        public bool IsFightFinished()
        {
            if(_player.IsDead() || _enemy.IsDead())
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
