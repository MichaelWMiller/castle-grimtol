using System;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool gameOver = false;

            Game game = new Game();
            Player currentPlayer = new Player();
            Room currentRoom = game.CurrentRoom;
            var egg = currentRoom.Items.Find(i => i.Name == "egg");
            currentPlayer.Score = 0;
            currentPlayer.Inventory.Add(egg);
            game.Setup();
            game.Intro();
               // Show Help Screen <N>ext
               // Then display 1st room, inside while loop with list of commands drawn, including quit...TODO work on this.
           }
        }
    }
}
