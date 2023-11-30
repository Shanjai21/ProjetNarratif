using System.Diagnostics;

namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal override string CreateDescription() =>
@"Tu est dans le toillette, Tu vois toi même es tu ne te souvient rien de toi.
Le [mirroir] te permet de voir ton reflet
Le [bain] donne option de une lavage.
La [chambre] te fait retourner à la chambre.
La mini porte est verouillé avec un code [????]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu te laisses relaxer dans le bain.");
                    break;
                case "mirroir":
                    Console.WriteLine("Tu aperçois les chiffres 2314 écrits sur la brume sur le miroir.");
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://postimg.cc/tnbQxcbg", UseShellExecute = true });
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                case "3459":
                    Console.WriteLine("Tu rentre dans la chambre.");
                    Game.Transition<mini_porte>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
