using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Game : IGame {
    public Game () { }

    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }
    private List<Room> _rooms { get; set; } = new List<Room> ();

    public void Reset () {

    }

    public void Setup () {

      //Set up rooms and descriptions
      Player monty = new Player (0);

      Room chasm = new Room ("chasm", "You are equipped for the long duration dive and are being lowered into inky blackness. Several minutes --and 40 feet into the dive with the stranded Cargador de Mar looming overhead--you glance down and see a phosphurescent glow below you getting brighter.");
      Room cave1 = new Room ("cave1", "The glow is stronger and you are lowered even with a coral cave opening 10 feet across with no other openings.  You shine your light and notice a shine off of an egg-shaped artifact near the north cave wall. If you want it, 'use egg'.");
      Room cave2 = new Room ("cave2", "After the debris settles and your vision clears, you see a small opening and decide to investigate.");
      Room cave3 = new Room ("cave3", "After the debris settles, your vision suddenly goes red.  You swipe at your face trying to clear your vision, then slap at your helmet.  The red cloud morphs into a cylinder with a sharp point and a hand-grip. The cave is otherwise empty about 20 feet in diameter. If you want the object, 'use red_rag'.");
      Room cave4 = new Room ("cave4", "After stowing the red mercury stuff in your bag, you enter the room to see glowing crystals..diamonds!..arranged in the wall of the coral with points radially aimed at a glowing doughnut-shaped ring laying in the middle of the cave floor. If you want it, 'use doughnut'.");
      _rooms.Add (chasm);
      _rooms.Add (cave1);
      _rooms.Add (cave2);
      _rooms.Add (cave3);
      _rooms.Add (cave4);
      Item egg = new Item ("egg", "Chrome-plated egg-shape device with ...Buttons!",
        "You pick it up and turn it over in your hands. You accidentally brush one of the buttons and are knocked into the cave wall from an explosion that occurred to the north.",
        "You eye the object with interest but decide to leave it lay. Searching the cave there doesn't appear to be any other opening. Suddenly you hear a whine coming from the device and a rocking explosion pushes you back.  On the cave wall appears to be an opening a few feet across in front of you. The device is no where to be seen. You're facing North.",
        false);

      Item red_rag = new Item ("red_rag", "Mysterious red cloth, flows like mercury, solidifies into weapon when you thwack it.",
        "Pointing the device at the far wall, you press the slide forward and a blackness pours out the tip and attaches to the coral.  A minute later a four-foot hole appears where the blackness attached to the coral. You head toward it.",
        "You let the red liquid settle to the floor.  Suddenly the red turns black and a white coral-encrusted skeletal arm reaches up, grabs your foot, and sucks you to hell. [YOU DIE, GAME OVER]",
        false);

      Item doughnut = new Item ("doughnut", "About 10 inches across, ring is 1.5 inches thick. Glows a neon light blue, pulsates.",
        "You reach down and examine the object.  While holding it firmly it glows more and pulls your whole body back through the cave rooms out the chasm and up to the waiting survey ship.  YOU FRICKING WIN!",
        "Suddenly the diamonds in the wall appear to be extending their points...rapidly...sharply...and impale you. YOU DIE! GAME OVER!",
        false);

      //chasm.Items.Add (egg);
      cave1.Items.Add (egg);
      cave3.Items.Add (red_rag);
      cave4.Items.Add (doughnut);

      //directions
      chasm.directions.Add ("down", cave1);

      //cave1.directions.Add ("east", cave4);
     // cave1.directions.Add("up", chasm);
      // cave1.directions.Add ("west", chasm);
      // cave1.directions.Add ("south", cave1);
      // cave1.directions.Add ("north", cave2);
      //cave1.directions.Add ("down", cave1);

      cave2.directions.Add ("east", cave3);
      cave2.directions.Add ("west", cave2);
      //cave2.directions.Add ("south", cave1);
      //cave2.directions.Add ("north", cave2);
      //cave2.directions.Add ("down", cave2);

      //cave3.directions.Add ("east", cave3);
      //cave3.directions.Add ("west", cave3);
      cave3.directions.Add ("south", cave4);
      //cave3.directions.Add ("north", cave3);
      //cave3.directions.Add ("down", cave3);

      // cave4.directions.Add ("east", cave4);
      // cave4.directions.Add ("west", cave1);
      // cave4.directions.Add ("south", cave4);
      // cave4.directions.Add ("north", cave3);
      // cave4.directions.Add ("down", cave4);

      CurrentRoom = chasm;
      CurrentPlayer = monty;

    }
    public void Intro () {

      System.Console.WriteLine ($@"
                      /~~~~~~~~~~~~~~~~~~~~~/
                     / Surviving Vanuatu!  /
                    /~~~~~~~~~~~~~~~~~~~~~/ 
            A text-based game...y'know.... for Kids!

            Welcome to Surviving Vanuatu!

In the South Pacific North of New Caledonia Southeast of the Solomon Islands and due west of Fiji lies the resort island of Vanuatu. A typical island resort with many fine hotels belies the sordid and sinister recent history of this Paradise in the Pacific!

In 1953 a raging typhoon capsized a Spanish cargo ship, the SS Cargador de Mar, laden with mostly refugee supply containers.   About 80 miles NW of Vanuatu, the ship sank in only 300 feet of water, coming to rest on top of an uncharted atoll.  The overloaded ship wasted no time in diving for the bottom, coming to rest on her bow and stern over a coral colony chasm.  On striking the atoll, the keel snapped and the ship's cargo in the main hold was discharged into the relatively stormy sea.

Among the cargo, smuggled from Spain destined for a secret black market sale, were a few articles of technology, technology the likes of which had not been invented... yet--or on earth...
            ");
      Console.WriteLine ("<N>ext");
      string userInput = Console.ReadLine ().ToLower ();
      if (userInput[0] == 'n') {
        Console.Clear ();
        Console.WriteLine ($@"
Apparently, the secret is out that these items even exist, and there have been a dozen attempts at salvage since the 50's. None of the diving personnel were ever seen or recovered from these attempts at retrieving the tech gold.

You are a salvage and treasure diver, contracted to a joint Vanuatu-ese and American corporation.  You have been made aware of the technically sophisticated devices that were smuggled aboard Cargador de Mar--made aware of their special capabilities. Among the items is a piece of red cloth about two feet square and feels fluid--like mercury--when you try to hold it, but if you pinch a corner of it--it forms a cylinder with a VERY sharp tip and what appears to be a handle on the other end. There are raised buttons on it as well, but their purpose is unknown.  Slapping the back of the grip returns the cloth to its mercurial consistency.  There were several other items, but their descriptions, use, and purposes are currently a mystery.");

      }
      System.Console.WriteLine ("<N>ext");
      userInput = Console.ReadLine ();
      if (userInput[0] == 'n') {
        Console.Clear ();
        System.Console.WriteLine ($@"
These items are believed to have fallen into the chasm where the Cargador de Mar is resting over precariously.  No one has dived the chasm yet, but a U.S. survey ship has loaded a camera and sonar module into the chasm, and there are four inter-connected coral caves.  The atoll with the chasm in the middle appears to be a tall, narrow structure, compared to the other atoll islands in the region.

Mission: After you are kitted out, conduct the dive from the survey/research vessel anchored over the position of the SS Cargador de Mar and recover the items. Don't get killed, disappear, or otherwise not be seen again.                
               ");
      }
    }

    public void DrawHelp () {

      System.Console.WriteLine ($@"
                    /~~~~~~~~~~~~~~~~~~~~~/
                   / Surviving Vanuatu!  /
                  /~~~~~~~~~~~~~~~~~~~~~/ 

    Commands available and their options:
    - 'go' <direction>` Moves the player from room to room, e.g. Go Down, type 'gd'
          Directions: 'north', 'south', 'east', 'west', 'down', 'up'
				Available directions are shown in game play.
				
    -  'use <itemName>' Uses an item in a room or from your inventory
		    Possible items: 'egg', 'red_rag', 'doughnut'
		    Example: 'use egg' 
	      Generally use items as they are presented.
    -  'quit' ...  Quits the Game
    -  'help' -  List of commands. Redraws this screen
    -  'look' -  Re-prints the room description
    -  'inventory' prints a list of the items in the players inventory
 
      When the player enters a room they get the room description
  ");
   CurrentRoom.GetDescription();
    }

    public string Prompt () {
      System.Console.WriteLine ($@"
  Make a move, Kid!____");
      return Console.ReadLine ().ToLower();
    }
    public void UseItem (string itemName) {
      var item = CurrentPlayer.Inventory.Find (i => i.Name == itemName);
      item = item == null ? CurrentRoom.UseItem (itemName) : item;
      if (item == null) {
        System.Console.WriteLine ("sorry there is no " + itemName);
        return;
      }
      if (item.ItemUsed) {
        System.Console.WriteLine ($@"
          Sorry, this item, the {item.Name},  has already been used...
        ");
      } else {
        System.Console.WriteLine ($@"
          You decide to use the item {item.Name}.
          Action:  
        ");

         CurrentRoom.GetDescription();        
        item.ItemUsed = false;
      }
      AlterRoom (item);
    }
    private void AlterRoom (Item item) {
      if (item.Name == "egg" && CurrentRoom.Name == "cave1") {
        System.Console.WriteLine (item.ItemUsedDescription);
       CurrentRoom.directions.Add ("north", _rooms.Find (r => r.Name == "cave2"));
      }
      if (item.Name == "red_rag" && CurrentRoom.Name == "cave3")
     { 
       System.Console.WriteLine(item.ItemUsedDescription);
      CurrentRoom.directions.Add("south", _rooms.Find (r => r.Name == "cave4"));
     }
     if (item.Name == "doughnut" && CurrentRoom.Name == "cave4")
     {
        System.Console.WriteLine(item.ItemUsedDescription);
        System.Console.WriteLine($@"
             /~~~~~~~~~~~~~~~~~~~~~~~~~~~/\
            /     Y O U   W I N ! ! !   /~~\
           /~~~~~~~~~~~~~~~~~~~~~~~~~~~/~~~~\
           \                           \~~~~/
            \   Thanks for Playing!     \~~/
             \~~~~~~~~~~~~~~~~~~~~~~~~~~~\/

");
     }
    }

    public void Go (string direction) {
      if (CurrentRoom.directions.ContainsKey (direction)) {
        CurrentRoom = CurrentRoom.directions[direction];
        CurrentRoom.GetDescription();
      } else {
        System.Console.WriteLine ("you cant go that way...");
      }
    }

  }
}