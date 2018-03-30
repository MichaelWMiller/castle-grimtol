using System;
using System.Configuration;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project {
    public class Program {
        public static void Main (string[] args) {
            bool gameOver = false;
            string userInput = "";
            Game game = new Game ();
            game.Setup ();

            System.Console.Clear ();
            //  game.Intro ();
            game.DrawHelp ();

            while (!gameOver) {
                userInput = game.Prompt ();
                string command = userInput;
                string options = "";
                if (userInput.Contains (" ")) {
                    var parsedInput = userInput.Split (' ');
                    command = parsedInput[0];
                    options = parsedInput[1];
                }

                switch (command) {
                    case "go":
                        game.Go (options);
                        break;
                    case "use":
                        game.UseItem (options);
                        break;
                    case "look":
                        Console.Clear();
                        game.CurrentRoom.GetDescription ();
                        break;
                    case "inventory":
                        System.Console.WriteLine ($@"
            Player's Inventory
            ------------------");
                        if (game.CurrentPlayer.Inventory.Count > 0) {

                            foreach (Item itm in game.CurrentPlayer.Inventory) {
                                System.Console.WriteLine ($@" {itm.Name}");
                            }
                        } else {
                            System.Console.WriteLine ("No items available for use");
                        }
                        game.Prompt ();
                        break;
                        case "help":
                        game.DrawHelp();
                        game.Prompt();
                        break;
                    case "quit":

                        System.Console.WriteLine ($@"
                    \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                     \   Thanks for Playing!     \
                      \~~~~~~~~~~~~~~~~~~~~~~~~~~~\

                    ");
                        gameOver = true;
                        break;
                    default:
                    game.DrawHelp();
                    game.Prompt();
                    break;
                }

            }

        } //Main{

    }
}