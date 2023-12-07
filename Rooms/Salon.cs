using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Salon : Room
    {
        internal override string CreateDescription() =>
@"Dans le couloir tu vois l'[office] 
La [cuisine] à ta gauche
Et tu vois le [garage] au l'autre bout du couloir
la [porte] pour retourner au chambre
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "office":
                    Console.WriteLine("Tu entres dans l'office.");
                    Game.Transition<Office>();
                    break;
                case "cuisine":
                    Console.WriteLine("Tu entres dans la cuisine.");
                    Game.Transition<Cuisine>();

                    break;
                case "garage":
                    Console.WriteLine("Tu montes dans le garage.");
                    Game.Transition<Garage>();
                    break;
                case "porte":
                    Console.WriteLine("Tu rentre au chambre.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

