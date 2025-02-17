﻿using System.Diagnostics;

namespace ProjetNarratif.Rooms
{
    internal class Bedroom : Room
    {
        internal override string CreateDescription() =>
@"Tu es reveillé dans une chambre tu ne c'est pas où tu es. Ton but est de sortir de cette salle.
La [porte] qui mène au couloir est devant toi.
Ta [toilette] privée est à ta gauche.
Dans ton armoire, tu aperçois le [grenier]
";

        internal override void  ReceiveChoice(string choice)

        {
            switch (choice)
            {
                case "toilette":
                    Console.WriteLine("Tu entres dans la toilette.");
                    Game.Transition<Bathroom>();
                    break;
                case "porte":
                    if (!AtticRoom.isKeyCollected)
                    {
                        Console.WriteLine("La porte est verrouillée.");
                    }
                    else
                    {
                        Console.WriteLine("Tu ouvres la porte avec ta clé et tu sors de ta chambre.");
                        Game.Transition<Salon>();
                    }
                    break;
                case "grenier":
                    Console.WriteLine("Tu montes dans le grenier.");
                    Game.Transition<AtticRoom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;


            }
        }
    }
}
