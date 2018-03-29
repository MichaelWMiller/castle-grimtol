using System;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project {
    public class Program {
        public static void Main (string[] args) {
            bool gameOver = false;

            Game game = new Game ();

            game.Setup ();

            //Console.Clear ();
            //  game.Intro ();
                game.DrawHelp ();
                
            while (!gameOver) {
                //Console.Clear ();
               game.Prompt ();
                string userInput = Console.ReadLine ();

                switch (userInput) {
                    case "h":
                       //Console.Clear ();
                        game.DrawHelp ();
                        System.Console.WriteLine("Where:    H");
                        // game.Prompt ();
                        // Console.ReadLine();
                        break;
                    case "gd":
                       // Console.Clear ();

                        if (game.CurrentRoom.directions["down"] == null) {
                            System.Console.WriteLine ("Nothing here try again");
                            System.Console.WriteLine("Where:   if of GD");
                            // game.Prompt ();
                            // Console.ReadLine();
                            game.DrawHelp ();
                        } else {
                            game.CurrentRoom = game.CurrentRoom.directions["down"];
                            var desc = game.CurrentRoom.Description;
                            System.Console.WriteLine ($"Description: {desc}");
                            var egg = game.CurrentRoom.Items.Find (i => i.Name == "egg");

                            System.Console.WriteLine ($"Item Description: {egg.Description}");
                            System.Console.WriteLine("Where:    Else of GD");
                        }
                        break;
                    case "te":
                        System.Console.WriteLine("Before TakeItem(egg)");
                        userInput = Console.ReadLine().ToLower();
                        var item = game.CurrentRoom.TakeItem ("egg");
                        game.CurrentPlayer.Inventory.Add (item);
                        System.Console.WriteLine("where:    TE");

                        // game.Prompt ();
                        // userInput = Console.ReadLine().ToLower();
                         break;
                     case "ue":
                        System.Console.WriteLine("Before UseItem...");
                        userInput = Console.ReadLine().ToLower();

                         Item itemUsed = game.CurrentRoom.UseItem ("egg");
                         game.CurrentPlayer.Inventory.Remove (itemUsed);
                         System.Console.WriteLine("Where:   UE");
                        //  game.Prompt ();
                        // userInput = Console.ReadLine().ToLower();
                         break;
                    case "gn":
                       // Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        game.DrawHelp ();
                        System.Console.WriteLine("Where:    GN");
                        // game.Prompt ();
                        
                        // userInput = Console.ReadLine().ToLower();
                        break;
                    case "gs":
                       // Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        //game.DrawHelp ();
                        System.Console.WriteLine("Where:    GS");
                        // game.Prompt ();
                        // userInput = Console.ReadLine().ToLower();
                        break;
                    case "ge":
                       // Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        //game.DrawHelp ();
                        System.Console.WriteLine("Where:    GE");
                        // game.Prompt ();
                        // userInput = Console.ReadLine().ToLower();
                        break;
                    case "gw":
                       // Console.Clear ();
                        System.Console.WriteLine ("Nothing here try again");
                        //game.DrawHelp ();
                        System.Console.WriteLine("Where:    GW");
                        // game.Prompt ();
                        // userInput = Console.ReadLine().ToLower();
                        break;
                    case "q":
                        gameOver = true;
                        game.Reset ();
                        System.Console.WriteLine("Where:    Q");
                        // userInput = Console.ReadLine().ToLower();
                        break;
                    default:
                        //game.DrawHelp ();
                        // userInput = Console.ReadLine().ToLower();
                        break;
                }
                Console.Clear ();

                // if (userInput != "te" && userInput != "ue") {
                //     var egg = game.CurrentRoom.Items.Find (i => i.Name == "egg");
                    //System.Console.Clear ();
                //     System.Console.WriteLine ($@"
                                
                //                 You have chosen NOT to use the egg!

                //                 Action:  {egg.ItemNotUsedDescription}

                //                 ");
                // }

                //gameOver = true;
                // System.Console.WriteLine("At bottom of loop");
                //         userInput = Console.ReadLine().ToLower();


                game.DrawHelp ();
                game.Prompt ();
                    userInput = Console.ReadLine ();
            }
        }
    }
}