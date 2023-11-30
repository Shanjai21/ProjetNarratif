using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Cuisine : Room
    {
        internal override string CreateDescription() =>
@"Tu es dans la cuisine
L'[armoire] qui mène à l'armoire.
Le [robinet] te fait couler l'eau.
La [porte] qui te mène au couloir.
";

        internal override void ReceiveChoice(string choice)

        {
            switch (choice)
            {
                case "armoire":
                    Console.WriteLine("Dans le coin de ton oeuil tu vois le chiffre 5.");
                    
                    break;
                case "robinet":
                    Console.WriteLine("L'eau coule et tu vois le chiffre 9.");
                    break;
                case "porte":
                    Console.WriteLine("Tu retourne au couloir.");
                    Game.Transition<Salon>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;


            }
        }
    }
}