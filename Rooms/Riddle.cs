using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Riddle : Room
    {
        internal override string CreateDescription() =>
@"Vous êtes dans une salle de devinette
Vous devez repondre al la question pour retourner [return].
";





        // Classe pour le personnage de la salle de devinette
        public class RiddleCharacter
        {
            public string Question { get; set; }
            public string[] Hints { get; set; }
            public string reponse { get; set; }
        }

        class Game
        {
            static void Main(string[] args)
            {
                // Création du personnage et initialisation des données
                RiddleCharacter riddleCharacter = new RiddleCharacter
                {
                    Question = "Je suis un animal, mais je n'ai pas de pattes. Qui suis-je ?",
                    Hints = new string[] { "Je suis connu pour miauler.", "J'adore boire du lait.", "Je suis souvent associé aux souris." },
                    reponse = "Chat"
                };

                // Simulation du joueur atteignant la nouvelle salle
                // (Cette partie serait adaptée selon la structure de votre jeu)
                Console.WriteLine("Vous arrivez dans une nouvelle salle...");

                // Appel de la salle de devinette
                EnterRiddleRoom(riddleCharacter);
            }

            static void EnterRiddleRoom(RiddleCharacter character)
            {
                int attempts = 3; // Nombre d'essais autorisés

                Console.WriteLine("Bienvenue dans la salle de devinette !");
                for (int i = 0; i < attempts; i++)
                {
                    Console.WriteLine($"\nDevinez qui je suis (Vous avez {attempts - i} essais restants) : {character.Question}");

                    string userAnswer = Console.ReadLine();

                    if (userAnswer.ToLower() == character.reponse.ToLower())
                    {
                        Console.WriteLine("Félicitations, vous avez trouvé la réponse ! Vous pouvez avancer dans le jeu.");
                        // Gérer la transition vers la suite du jeu...
                        return;
                    }
                    else
                    {
                        if (i < attempts - 1)
                        {
                            Console.WriteLine($"Dommage, ce n'est pas la bonne réponse. Voici un nouvel indice : {character.Hints[i]}");
                        }
                        else
                        {
                            Console.WriteLine($"Désolé, vous n'avez plus d'essais. La réponse était : {character.reponse}. Le jeu se termine ici.");
                            // Gérer la fin du jeu ou un retour à une étape précédente...
                            return;
                        }
                    }
                }
            }
        }
    }
}

