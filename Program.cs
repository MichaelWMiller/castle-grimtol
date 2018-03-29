using System;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project {
    public class Program {
        public static void Main (string[] args) {
            bool gameOver = false;

            Game game = new Game ();
            Player currentPlayer = new Player ();
            Room currentRoom = game.CurrentRoom;
            currentPlayer.Score = 0;
            game.Setup ();
            game.Intro ();

            while (!gameOver) {
                Console.Clear ();
                game.DrawHelp ();
                game.Prompt ();
                string userInput = Console.Read ().ToString ().ToLower ();
                var foundRoom = currentRoom;
                switch (userInput) {
                    case "h":
                        Console.Clear ();
                        game.DrawHelp ();
                        break;
                    case "gd":
                        Console.Clear ();
                        foundRoom = currentRoom.directions["down"];
                        if (foundRoom == null) {
                            System.Console.WriteLine ("Nothing here try again");
                            game.DrawHelp ();
                        } else {
                            currentRoom = currentRoom.directions["down"];
                            var desc = currentRoom.Description;
                            System.Console.WriteLine ($"Description: {desc}");
                            var egg = currentRoom.Items.Find (i => i.Name == "egg");

                            System.Console.WriteLine ($"Item Description: {egg.Description}");

                            game.Prompt ();
                            userInput = Console.ReadLine ().ToString ().ToLower ();
                            if (userInput == "ti") {
                                currentPlayer.Inventory.Add (currentRoom.TakeItem (egg.Name));
                                egg.ItemUsed = true;
                                Console.Clear ();
                                System.Console.WriteLine ($@"
                                    You have taken the item!
                           {egg.ItemUsedDescription}         
                                    ");
                            }
                        }
                        break;
                    case "gn":
                        Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        game.DrawHelp ();
                        game.Prompt ();
                        break;
                    case "gs":
                        Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        game.DrawHelp ();
                        game.Prompt ();
                        break;
                    case "ge":
                        Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        game.DrawHelp ();
                        game.Prompt ();
                        break;
                    case "gw":
                        Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        game.DrawHelp ();
                        game.Prompt ();
                        break;
                    case "q":
                        game.Reset ();
                        break;
                    default:
                        game.DrawHelp ();
                        break;
                }

                gameOver = true;
            }
        }
    }
}