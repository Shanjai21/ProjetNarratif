using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Ordi : Room
    {
        internal override string CreateDescription() =>
@"Tu es à l'interieur de l'ordi et tu vois des fichiers.
Vous avez le choix [fichier] et [journal]
Faire un [retour] pour retourner au salon
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "fichier":
                    Console.WriteLine("LISTE DES PATIENTS.");
                    Console.WriteLine("Mark#1.");
                    Console.WriteLine("Johanne#2.");
                    Console.WriteLine("Johnny#3.");
                    Console.WriteLine("Sarah#4.");
                    Console.WriteLine("Julie#5.");
                    Console.WriteLine("Lucie#6.");
                    Console.WriteLine("Luke#7.");
                    Console.WriteLine("Josh#8.");
                    Console.WriteLine("Megan#9.");
                    Console.WriteLine("Garett#10.");
                    Console.WriteLine("Juan#11.");
                    break;
                case "journal":
                    Console.WriteLine(@"Journée 1 Ma femme est mort je me sens seule");
                    Console.WriteLine(@"Journée 3 Je suis au park passer mes journées tristes");
                    Console.WriteLine(@"Journée 5 J'ai vu cet enfant au park il s'appelle Mark");
                    Console.WriteLine(@"Journée 6 Mark m'a montré un jouet resemble beucoup a Thomas le train");
                    Console.WriteLine(@"Journée 7 J'ai cette soudaine envie de faire quelque chose je sais pas c'est quoi cet emotion  ");
                    Console.WriteLine(@"Journée 8 Je suis au park regarder la nature. Je vois Mark jouet avec Thomas");
                    Console.WriteLine(@"Journée 10 Cet emotion devient plus en plus grand");
                    Console.WriteLine(@"Journée 12 Je retourne au park et je joue avec Mark");
                    Console.WriteLine(@"Journée 14 J'apporte des bonbons pour Mark");
                    Console.WriteLine(@"Journée 17 Je veux garder Mark");
                    Console.WriteLine(@"Journée 18 Mark me suive il me croit à moi ");
                    Console.WriteLine(@"Journée 19 Mark est dans ma maison");
                    Console.WriteLine(@"Journée 22 Mark m'a suivie avec les bonbons ");
                    Console.WriteLine(@"Journée 23 Mark demande pour sa maman");
                    Console.WriteLine(@"Journée 23 J'ai frapper Mark");
                    Console.WriteLine(@"Journée 23 Mark ne bouge plus");
                    Console.WriteLine(@"Journée 23 Mark ne respire plus");
                    Console.WriteLine(@"Journée 23 Mon emotion grandi");
                    Console.WriteLine(@"Journée 23 J'ai pris mon scalpel et j'ai coupé le corps");
                    Console.WriteLine(@"Journée 23 J'aimé se sentiment");
                    Console.WriteLine(@"Journée 32 Nouvelle enfant elle s'appelle Johanne");
                    Console.WriteLine(@"Journée 35 Elle n'a pas crier elle était silencieux");
                    Console.WriteLine(@"Journée 42 Se sentiment est bon.");
                    Console.WriteLine(@"Journée 48 Se sentiment est bon.");
                    Console.WriteLine(@"Journée 69 Se sentiment est bon.");
                    Console.WriteLine(@"Journée 73 Se sentiment est bon.");
                    break;
                case "retour":
                    Game.Transition<Office>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }

        }
    }
}