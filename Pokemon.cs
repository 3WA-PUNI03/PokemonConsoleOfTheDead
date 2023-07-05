using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetPowa
{
    internal class Pokemon
    {
        // Champs / Field

        // General
        private string _name;
        private int _level;
        // Health
        private int _currentHp;
        private int _hpMax;
        // Stat
        private int _attack;
        private int _defense;
        private int _speed;

        // Propriétés / Property
        public string Name => _name;
        public int CurrentHp
        {
            get => _currentHp;
        }
        public int HpMax { get => _hpMax; }


        // Constructeur / Constructor
        public Pokemon(string name, int maxHp)
        {
            _name = name;
            _level = 5;
            _currentHp = maxHp;
            _hpMax = maxHp;
            _attack = 25;
            _defense = 25;
            _speed = 100;
        }

        // Méthodes / Methodes
        /// <summary>
        /// Impact current health based on amount 
        /// </summary>

        public void Damage(int amount)
        {
            if (amount <= 0) return; // Guard

            _currentHp -= amount;
            Console.WriteLine($"{_name} a prit {amount} point de degat");

            // Clamp value
            if (_currentHp <= 0)
            {
                _currentHp = 0;
            }
        }

        public void Heal(int amount)
        {
            if (amount <= 0) return; // Guard
            if (IsDead()) return;

            _currentHp += amount;
            Console.WriteLine($"{_name} a récupéré {amount} pv");

            // Clamp value
            if (_currentHp > _hpMax)
            {
                _currentHp = _hpMax;
            }
        }
        // Polymorphisme ad hoc
        public void Heal(PotionType potion)
        {
            switch (potion)
            {
                case PotionType.Potion:
                    Heal(50);
                    break;
                case PotionType.SuperPotion:
                    Heal(100);
                    break;
                case PotionType.HyperPotion:
                    Heal(200);
                    break;
                case PotionType.PotionMax:
                    _currentHp = _hpMax;
                    break;
                default:
                    break;
            }
        }

        public void Resurection(RappelType rappel)
        {
            if (rappel == RappelType.Basique)
            {
                _currentHp = 1;
            }
            else if (rappel == RappelType.Max)
            {
                _currentHp = _hpMax;
            }
        }

        public bool IsDead()
        {
            if (_currentHp <= 0)
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
