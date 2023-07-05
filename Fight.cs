using System;
using System.Collections.Generic;
using System.Linq;
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
        public void PlayRound()
        {


            // A la fin on indique la situation du combat
            Console.WriteLine("la vie");
        }

    }
}
