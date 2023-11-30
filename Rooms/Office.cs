using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Office : Room
    {
        internal override string CreateDescription() =>
@"Tu es dans l'office.
Tu vois l'[ordi] permet de l'utiliser.
Dans la table tu vois une [note] et tu vois des [document]s.
La [porte] pour retourner au couloir
";

        internal override void ReceiveChoice(string choice) 
        {
            switch (choice)
            {
                case "note":
                    Console.WriteLine("Tu voix la note Dr.John");
                    break;
                case "ordi":
                    Console.WriteLine("tu rentre dans l'ordi");
                    Game.Transition<Ordi>();
                    break;
                case "document":
                    Console.WriteLine("Tu vois le fichier avec MENTAL REPORT pour Doctor John Kenedy ");
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://postimg.cc/tnRbccMM", UseShellExecute = true });
                    break;
                case "porte":
                    Game.Transition<Salon>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }

        }
    }
}
