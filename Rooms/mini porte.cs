using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class mini_porte : Room
    {
        internal override string CreateDescription() =>
@"Dans la mini porte tu vois un horreur.
Tu ne sais pas quoi dire. La salle est dégeulasse tu as vomit.
Tu te rendre compte que tu est dans un abattoir
Tu voie une [salle_secret] peut te diriger vers la sortie
.
";

        internal override void ReceiveChoice(string choice)
        {
            
            switch (choice)
            {
                case "salle_secret":

                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://postimg.cc/4Hhk7hmX", UseShellExecute = true });
                    Console.WriteLine("Tu rentre dans la salle secret.");
                    Game.Transition<Salle_Secret>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }

        }
    }
}
