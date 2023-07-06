using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie
{
    class Chien : Animal
    {
        bool vacciné;

        public Chien(string name) : base(name, 4)
        {
            vacciné = true;
        }

        public override void Crier()
        {
            base.Crier();
        }
    }
}
