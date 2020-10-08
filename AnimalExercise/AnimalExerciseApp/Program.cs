using System;
using Session05Animals;

namespace AnimalExerciseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Cow(1);
            myAnimal = new Cow(1);

            
            Chicken myChecken = new Chicken(1);

            // tvingar variabeln att bli en Cow (tvingad datakonvertering)
            // genererar InvalidCastExeption
            Cow myCow = (Cow)myAnimal;

            // Säker datakonvertering
            // Blir null om det inte går att konvertera (måste vara en nullable typ)
            myCow = myAnimal as Cow;

            IBarnyardAnimal mybarnYardAnimal = new Chicken(1);
            mybarnYardAnimal.FeedingArea = "Main yard"; // Ändrar värdet på FeedingArea
            // mybarnYardAnimal.RestingArea = "" går inte för att det bara är get (hämta värde) inte set (ändra värde)

            myAnimal = (Animal)mybarnYardAnimal;
        }
    }
}
