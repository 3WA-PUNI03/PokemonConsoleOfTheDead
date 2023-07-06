using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie
{
    public class TheAnimalerie
    {
        List<Animal> _animals;

        public TheAnimalerie()
        {
            Animal[] a;
            _animals = new List<Animal>();
            _animals.Add(new Chien("Nougat"));
            _animals.Add(new Chat("Ganache"));
            _animals.Add(new Chat("Radis"));
            _animals.Add(new Chat("Reglisse"));
            //Animal monprefere = new Chien("Rufus");
            //_animals.Add(monprefere);


            //foreach (Animal animal in _animals)
            //{
            //    animal.Crier();
            //    _animals.Add(new Chien(""));
            //}

            //for (int i = 0; i < _animals.Count; i++)
            //{
            //    _animals[i].Crier();
            //    _animals.Add(new Chien(""));
            //}


        }

        public void AddAnimal( Animal animal )
        {
            _animals.Add(animal);
        }



    }
}
