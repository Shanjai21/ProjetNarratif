using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Bedroom());
game.Add(new Bathroom());
game.Add(new AtticRoom());
game.Add(new Salon());
game.Add(new Garage());
game.Add(new Salle_Secret());
game.Add(new mini_porte());
game.Add(new Office());
game.Add(new Cuisine());
game.Add(new Ordi());
game.Add(new Riddle());

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();