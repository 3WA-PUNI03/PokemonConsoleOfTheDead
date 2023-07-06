
using Animalerie;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        TheAnimalerie animalerie = new TheAnimalerie();

        Chien rufus = new Chien("Rufus");
        Chat nougat = new Chat("Nougat");

        animalerie.AddAnimal(rufus);
        animalerie.AddAnimal(nougat);


        if(rufus is Animal)
        {

        }


        rufus.Crier();
        nougat.Crier();

        Console.ReadKey();
    }
}