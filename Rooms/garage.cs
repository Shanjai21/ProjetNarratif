using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Garage : Room
    {
        internal override string CreateDescription() =>
@"Tu est dans le garage
La [voiture] te permet de regarder la voiture.
Le [calendrier] te donne la date.
La [porte] te retourne au couloir.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "voiture":
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://www.r8talk.com/attachments/251877/", UseShellExecute = true });
                    break;
                case "calendrier":
                    Console.WriteLine("Tu aperçois le chiffre 34 dans le calendrier.");
                    break;
                case "porte":
                    Console.WriteLine("Tu retournes dans le couloir.");
                    Game.Transition<Salon>();
                    break;
                
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}