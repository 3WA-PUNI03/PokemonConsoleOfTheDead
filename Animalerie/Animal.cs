

namespace Animalerie
{
    public abstract class Animal
    {
        protected string _name;
        protected int _nbPatte;

        public Animal(string name, int nbPatte)
        {
            _name = name;
            _nbPatte = nbPatte;
        }

        public virtual void Crier()
        {

        }



    }
}
