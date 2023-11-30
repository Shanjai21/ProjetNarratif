using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Salle_Secret : Room
    {
        internal override string CreateDescription() =>
@"Tu est dans la salle secret.
Tu voit un [portrait].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                
                case "portrait":
                    Console.WriteLine("Tu vois ton portrait de toi même");
                    Console.WriteLine("Tous se cloche tu t'appelle John Kenedy");
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://postimg.cc/MnHkVRC1", UseShellExecute = true });

                    break;
                
                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
            Game.Finish();
        }

    }
}