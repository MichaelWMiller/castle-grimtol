using System;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project {
    public class Program {
        public static void Main (string[] args) {
            bool gameOver = false;

            Game game = new Game ();
            Player currentPlayer = new Player ();
            Room currentRoom = game.CurrentRoom;
            string curRoom = game.CurrentRoom;
           
           
            //var egg = currentRoom.Items.Find (i => i.Name == "egg");
            currentPlayer.Score = 0;
            //currentPlayer.Inventory.Add (egg);
            game.Setup ();
            game.Intro ();

            // Show Help Screen <N>ext
            // Then display 1st room, inside while loop with list of commands drawn, including quit...TODO work on this.
            while (!gameOver) {
                Console.Clear ();

                //    var i = 1;.

                game.DrawHelp ();
                game.Prompt ();
                string userInput = Console.Read ().ToLower ();
                switch (userInput) {
                    case "h":
                        Console.Clear ();
                        game.DrawHelp ();
                        break;
                    case "gd":
                        Console.Clear ();
                        //Figure this shit out... need to pass current room, 2-letter user choice.
                        Game.SetupCurrentRoom (currentRoom, userInput);
                        break;
                    case "gn":
                        Console.Clear ();
                        Game.SetupCurrentRoom (userInput);
                        break;
                    case "gs":
                        Console.Clear ();
                        Game.SetupCurrentRoom (userInput);
                        break;
                    case "ge":
                        Console.Clear ();
                        Game.SetupCurrentRoom (userInput);
                        break;
                    case "gw":
                        Console.Clear ();
                        Game.SetupCurrentRoom (userInput);
                        break;
                    case "q":
                        game.Reset ();
                        break;
                    default:
                        game.DrawHelp ();
                        break;
                }

                System.Console.WriteLine ($@"
                
                ");

                gameOver = true;
            }
        }
    }
}