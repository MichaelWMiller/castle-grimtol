using System;
using System.Configuration;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project {
    public class Program {
        public static void Main (string[] args) {
            bool gameOver = false;
            bool noEggUsed = true;
            bool noRedRagUsed = true;
            bool noDoughNutUsed = true;
            string desc = "";
            string userInput = "";
            string switchInput = "";

            Game game = new Game ();

            game.Setup ();

            System.Console.Clear ();
            //  game.Intro ();
            game.DrawHelp ();
            //Stay in the game until Q selected
            while (!gameOver) {
                string curName = game.CurrentRoom.Name.ToLower ();
                System.Console.WriteLine ($" {curName}");
                #region "chasm"
                if (game.CurrentRoom.Name.ToLower () == "chasm") {
                    game.Prompt ();
                    switchInput = Console.ReadLine ();

                    switch (switchInput) {
                        case "h":
                            Console.Clear ();
                            game.DrawHelp ();
                            game.Prompt ();
                            Console.ReadLine ();
                            break;
                        case "i":
                            System.Console.WriteLine ("The letter 'i' was selected.");
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
                        case "l":
                            desc = game.CurrentRoom.Description;
                            System.Console.WriteLine ($@"
Room Description: {desc}
                                ");
                            game.Prompt ();
                            break;
                        case "gd":
                            Console.Clear ();

                            if (game.CurrentRoom.directions["down"] == null) {
                                System.Console.WriteLine ("Nothing here try again");
                                game.DrawHelp ();
                            } else {
                                game.CurrentRoom = game.CurrentRoom.directions["down"];
                                // Now current room is cave1. Fall to next big 'if' statement (cave1)
                            }
                            break;
                        case "te":
                            var item = game.CurrentRoom.TakeItem ("egg");
                            game.CurrentPlayer.Inventory.Add (item);
                            break;
                        case "ue":
                            userInput = Console.ReadLine ().ToLower ();
                            Item itemUsed = game.CurrentRoom.UseItem ("egg");
                            itemUsed.ItemUsed = true;
                            noEggUsed = false;
                            break;
                        case "gn":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "gs":
                            System.Console.WriteLine ($@"
                        
                        
Nothing here try again");
                            break;
                        case "ge":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "gw":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "q":

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
                            userInput = Console.ReadLine().ToLower();
                            break;
                    } //end switch
                } // end if curr room = 'chasm'
#endregion "chasm"
#region "cave1"
                if (game.CurrentRoom.Name == "cave1") {

                    desc = game.CurrentRoom.Description;
                    System.Console.WriteLine($@"
Room Description: {desc}");

                    Item myEgg = game.CurrentRoom.Items.Find(i => i.Name == "egg");

                    System.Console.WriteLine($@"
                                
                                
Item Description: {myEgg.Description}
                                
                                ");
                    game.Prompt();
                    switchInput = Console.ReadLine();

                    switch (switchInput) {
                        case "h":
                            Console.Clear();
                            game.DrawHelp();

                            game.Prompt();
                            Console.ReadLine();
                            break;
                        case "i":
                            System.Console.WriteLine("The letter 'i' was selected.");
                            System.Console.WriteLine($@"
Player's Inventory
------------------");
                            if (game.CurrentPlayer.Inventory.Count > 0) {

                                foreach (Item itm in game.CurrentPlayer.Inventory) {
                                    System.Console.WriteLine($@" {itm.Name}");
                                }
                            } else {
                                System.Console.WriteLine("No items available for use");
                            }
                            game.Prompt();
                            break;
                        case "l":
                            desc = game.CurrentRoom.Description;
                            System.Console.WriteLine($@"
Room Description: {desc}
                                ");
                            game.Prompt();
                            break;

                        case "gd":
                            System.Console.WriteLine($@"
                       

Nothing here try again");
                            break;
                        case "te":
                            var item = game.CurrentRoom.TakeItem("egg");
                            game.CurrentPlayer.Inventory.Add(item);
                            break;
                        case "tr":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "td":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "ur":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "ud":
                            System.Console.WriteLine("Nothing to take");
                            break;

                        case "ue":
                            userInput = Console.ReadLine().ToLower();
                            Item itemUsed = game.CurrentRoom.UseItem("egg");
                            itemUsed.ItemUsed = true;
                            noEggUsed = false;
                            break;
                        case "gn":
                            //put this in GN... set a flag at top noEggRead = true. At bottom of this if, 
                            //set noEggRead = false.
                            //Item egg = game.CurrentRoom.Items.Find(i => i.Name == "egg");
                            //string rm = game.CurrentRoom.Name;
                            if (noEggUsed) {
                                System.Console.WriteLine($@"
                                
You have chosen NOT to use the egg!

Action:  {myEgg.ItemNotUsedDescription}

You are still facing North.

                                ");
                                noEggUsed = false;
                                game.Prompt();
                                userInput = Console.ReadLine().ToLower();
                            }

//                             Item red_rag = game.CurrentRoom.Items.Find(i => i.Name == "red_rag");
//                             if (noRedRagUsed) {
//                                 System.Console.WriteLine ($@"
                                
// You have chosen NOT to use the red rag!

// Action:  {red_rag.ItemNotUsedDescription}

//                                 ");

//                                 noRedRagUsed = false;
//                                 System.Console.WriteLine ($@"
//                             \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
//                              \   Thanks for Playing!     \
//                               \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                        
//                             ");
 
//                             gameOver = true;
//                             }



                            if (game.CurrentRoom.directions["north"] == null) {
                                System.Console.WriteLine("Nothing here try again");
                                game.DrawHelp();
                            } else {
                                //the correct path
                                game.CurrentRoom = game.CurrentRoom.directions["north"];
                                // Now current room is cave2. Fall to next big 'if' statement (cave2)
                            }
                            break;
                        case "gs":
                            System.Console.WriteLine ($@"
                        
                        
Nothing here try again");
                            break;
                        case "ge":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "gw":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "q":

                            System.Console.WriteLine ($@"
                            \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                             \   Thanks for Playing!     \
                              \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                        
                            ");
                            gameOver = true;
                            break;
                        default:
                            break;
                    }
                    // Item egg = game.CurrentRoom.Items.Find(i => i.Name == "egg");
                    // string rm = game.CurrentRoom.Name;

                } //end if curr room = 'cave1'
#endregion "cave1"

#region "cave2"
                if (game.CurrentRoom.Name == "cave2") {
                    desc = game.CurrentRoom.Description;
                    System.Console.WriteLine($@"
Room Description: {desc}");

                    game.Prompt();
                    switchInput = Console.ReadLine();

                    switch (switchInput) {
                        case "h":
                            Console.Clear();
                            game.DrawHelp();

                            game.Prompt();
                            Console.ReadLine();
                            break;
                        case "i":
                            System.Console.WriteLine("The letter 'i' was selected.");
                            System.Console.WriteLine($@"
Player's Inventory
------------------");
                            if (game.CurrentPlayer.Inventory.Count > 0) {

                                foreach (Item itm in game.CurrentPlayer.Inventory) {
                                    System.Console.WriteLine($@" {itm.Name}");
                                }
                            } else {
                                System.Console.WriteLine("No items available for use");
                            }
                            game.Prompt();
                            break;
                        case "l":
                            desc = game.CurrentRoom.Description;
                            System.Console.WriteLine($@"
Room Description: {desc}
                                ");
                            game.Prompt();
                            break;

                        case "gd":
                            System.Console.WriteLine($@"
 

Nothing here try again");
                            break;
                        case "te":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "tr":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "td":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "ur":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "ud":
                            System.Console.WriteLine("Nothing to take");
                            break;

                        case "ue":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "gn":
                            System.Console.WriteLine($@"
                       

Nothing here try again");
                            break;
                        case "gs":
                            System.Console.WriteLine($@"
                        
                        
Nothing here try again");
                            break;
                        case "ge":

                            if (game.CurrentRoom.directions["east"] == null) {
                                System.Console.WriteLine("Nothing here try again");
                                game.DrawHelp();
                            } else {
                                //the correct path
                                game.CurrentRoom = game.CurrentRoom.directions["east"];
                                // Now current room is cave3. Fall to next big 'if' statement (cave3)
                            }
                            break;
                        case "gw":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "q":

                            System.Console.WriteLine ($@"
                            \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                             \   Thanks for Playing!     \
                              \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                        
                            ");
                            gameOver = true;
                            break;
                        default:
                            break;
                    }
                    string rm = game.CurrentRoom.Name;

                    System.Console.WriteLine ("Im in cave2 at console readline");
                    game.CurrentRoom = game.CurrentRoom.directions["east"];
                    userInput = Console.ReadLine ();
                } // end if curr room = 'cave2'
                #endregion "cave2"

#region "cave3"
                if (game.CurrentRoom.Name == "cave3") {
                    desc = game.CurrentRoom.Description;
                    System.Console.WriteLine ($@"
Room Description: {desc}");

                    Item red_rag = game.CurrentRoom.Items.Find (i => i.Name == "red_rag");

                    System.Console.WriteLine ($@"
                                
                                
Item Description: {red_rag.Description}
                                
                                ");
                    game.Prompt ();
                    switchInput = Console.ReadLine ();

                    switch (switchInput) {
                        case "h":
                            Console.Clear ();
                            game.DrawHelp ();

                            game.Prompt ();
                            Console.ReadLine ();
                            break;
                        case "i":
                            System.Console.WriteLine ("The letter 'i' was selected.");
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
                        case "l":
                            desc = game.CurrentRoom.Description;
                            System.Console.WriteLine ($@"
Room Description: {desc}
                                ");
                            game.Prompt ();
                            break;

                        case "gd":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "tr":
                            var item = game.CurrentRoom.TakeItem ("red_rag");
                            game.CurrentPlayer.Inventory.Add (item);
                            break;
                        case "te":
                            System.Console.WriteLine ("Nothing to take");
                            break;
                        case "td":
                            System.Console.WriteLine ("Nothing to take");
                            break;
                        case "ue":
                            System.Console.WriteLine ("Nothing to take");
                            break;
                        case "ud":
                            System.Console.WriteLine ("Nothing to take");
                            break;

                        case "ur":
                            userInput = Console.ReadLine ().ToLower ();
                            Item ragUsed = game.CurrentRoom.UseItem ("red_rag");
                            ragUsed.ItemUsed = true;
                            noRedRagUsed = false;
                            break;
                        case "gn":


                            System.Console.WriteLine ($@"
                        
                        
Nothing here try again");
                            break;
                        case "gs":
                            if (game.CurrentRoom.directions["south"] == null) {
                                System.Console.WriteLine ("Nothing here try again");
                                game.DrawHelp ();
                            } else {
                                //the correct path
                                game.CurrentRoom = game.CurrentRoom.directions["south"];
                                // Now current room is cave4. Fall to next big 'if' statement (cave4)
                            }
                            break;
                        case "ge":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "gw":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "q":

                            System.Console.WriteLine ($@"
                            \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                             \   Thanks for Playing!     \
                              \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                        
                            ");
                            gameOver = true;
                            break;
                        default:
                            break;
                    }

                    desc = game.CurrentRoom.Description;
//                     System.Console.WriteLine($@"
// Room Description: {desc}");
                    System.Console.WriteLine("Im in cave3 at console readline");
                    game.CurrentRoom = game.CurrentRoom.directions["south"];
                    userInput = Console.ReadLine();
                } // end if curr room = 'cave3'

                #endregion "cave3"

                #region "cave4"

                if (game.CurrentRoom.Name == "cave4") {

                Item red_rag = game.CurrentRoom.Items.Find(i => i.Name == "red_rag");
                    if (noRedRagUsed) {
                        System.Console.WriteLine ($@"
                                
You have chosen NOT to use the red rag!

Action:  {red_rag.ItemNotUsedDescription}

                                ");

                        noRedRagUsed = false;
                        System.Console.WriteLine ($@"
                            \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                             \   Thanks for Playing!     \
                              \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                        
                            ");
 
                        gameOver = true;
                    }

                    desc = game.CurrentRoom.Description;
                    System.Console.WriteLine($@"
Room Description: {desc}");

                    Item doughnut = game.CurrentRoom.Items.Find (i => i.Name == "doughnut");

                    System.Console.WriteLine ($@"
                                
                                
Item Description: {doughnut.Description}
                                
                                ");
                    game.Prompt();
                    switchInput = Console.ReadLine();

                    switch (switchInput) {
                        case "h":
                            Console.Clear();
                            game.DrawHelp();

                            game.Prompt();
                            Console.ReadLine();
                            break;
                        case "i":
                            System.Console.WriteLine("The letter 'i' was selected.");
                            System.Console.WriteLine($@"
Player's Inventory
------------------");
                            if (game.CurrentPlayer.Inventory.Count > 0) {

                                foreach (Item itm in game.CurrentPlayer.Inventory) {
                                    System.Console.WriteLine($@" {itm.Name}");
                                }
                            } else {
                                System.Console.WriteLine("No items available for use");
                            }
                            game.Prompt();
                            break;
                        case "l":
                            desc = game.CurrentRoom.Description;
                            System.Console.WriteLine($@"
Room Description: {desc}
                                ");
                            game.Prompt();
                            break;

                        case "gd":
                            System.Console.WriteLine($@"
 

Nothing here try again");
                            break;
                        case "te":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "tr":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "td":
                            var item = game.CurrentRoom.TakeItem("doughnut");
                            game.CurrentPlayer.Inventory.Add(item);
                            break;
                        case "ur":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "ud":
                            Item myDoughnut = game.CurrentRoom.Items.Find(i => i.Name == "doughnut");
                            
                        System.Console.WriteLine ($@"
                                
You have chosen to USE  the DOUGHNUT!!!

Action:  {myDoughnut.ItemUsedDescription}

                                ");

                       Console.Clear();
                        System.Console.WriteLine ($@"
                              /~~~~~~~~~~~~~~~~~~~~~~~~~~~/\
                             /     Y O U   W I N ! ! !   /~~\
                            /~~~~~~~~~~~~~~~~~~~~~~~~~~~/~~~~\
                            \~~~~~~~~~~~~~~~~~~~~~~~~~~~\~~~~/
                             \   Thanks for Playing!     \~~/
                              \~~~~~~~~~~~~~~~~~~~~~~~~~~~\/
                        
                            ");
 
                        gameOver = true;
                                            

                            break;
                        case "ue":
                            System.Console.WriteLine("Nothing to take");
                            break;
                        case "gn":
                            System.Console.WriteLine($@"
                       

Nothing here try again");
                            break;
                        case "gs":
                            System.Console.WriteLine($@"
                        
                        
Nothing here try again");
                            break;
                        case "ge":
                        Item aDoughNut = game.CurrentRoom.Items.Find(i => i.Name == "doughnut");
                    if (noDoughNutUsed) {
                        System.Console.WriteLine ($@"
                                
You have chosen NOT to use the DOUGHNUT!

Action:  {aDoughNut.ItemNotUsedDescription}

                                ");

                        noRedRagUsed = false;
                        System.Console.WriteLine ($@"
                            \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                             \   Thanks for Playing!     \
                              \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                        
                            ");
 
                        gameOver = true;
                    }

                            // if (game.CurrentRoom.directions["east"] == null) {
                            //     System.Console.WriteLine("Nothing here try again");
                            //     game.DrawHelp();
                            // } else {
                            //     //the correct path
                            //     game.CurrentRoom = game.CurrentRoom.directions["east"];
                                
                            // }
                            break;
                        case "gw":
                            System.Console.WriteLine ($@"
                       

Nothing here try again");
                            break;
                        case "q":

                            System.Console.WriteLine ($@"
                            \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                             \   Thanks for Playing!     \
                              \~~~~~~~~~~~~~~~~~~~~~~~~~~~\
                        
                            ");
                            gameOver = true;
                            break;
                        default:
                            break;
                    }
                    string rm = game.CurrentRoom.Name;


                    desc = game.CurrentRoom.Description;
                    System.Console.WriteLine($@"
Room Description: {desc}");
                    System.Console.WriteLine("Im in cave4 at console readline");
                    game.CurrentRoom = game.CurrentRoom.directions["west"];
                    userInput = Console.ReadLine();

                } // end if curr room = 'cave4'

                #endregion "cave4"

                //gameOver = true;
            } //gameOver loop
        } //Main{

    }
}