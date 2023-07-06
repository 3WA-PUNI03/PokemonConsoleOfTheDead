
namespace Animalerie
{
    class Chat : Animal
    {
        public Chat(string name) : base(name, 4)
        {
        }


        public override void Crier()
        {
            Console.WriteLine("Miaou");
        }
    }
}
