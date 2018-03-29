using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Game : IGame {
    public Game () { }

    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public void Reset () {
      bool gameOver = true;
    }
public void SetupCurrentRoom(string uc) {
  switch(uc.Substring(1,1))
  {
    case "d":
    
  
      //see if current room and direction exist (loop?)
      //need to a.  Take current room, direction, read dictionary value of next room
      //set value of current room with next room
      //draw description from Room list? dictionary?
      //check for items, show "Items in room:  ", list item.draw on display if available
      //prompt user, see if take or use item
      //
    break;
  }
}
    public void Setup () {

      //Set up rooms and descriptions

      Room chasm = new Room ("Chasm", "You are equipped for the long duration dive and are being lowered into inky blackness. Several minutes --and 40 feet into the dive with the stranded Cargador de Mar looming overhead--you glance down and see a phosphurescent glow below you getting brighter.");
      Room cave1 = new Room ("Cave 1", "The glow is stronger and you are lowered even with a coral cave opening 10 feet across.  You shine your light and notice a shine off of an egg-shaped artifact near the north cave wall.");
      Room cave2 = new Room ("Cave 2", "After the debris settles and your vision clears, you see a small opening ");
      Room cave3 = new Room ("Cave 3", "After the debris settles, your vision suddenly goes red.  You swipe at your face trying to clear your vision, then slap at your helmet.  The red cloud morphs into a cylinder with a sharp point and a hand-grip. The cave is otherwise empty about 20 feet in diameter.");
      Room cave4 = new Room ("Cave 4", "After stowing the red mercury stuff in your bag, you enter the room to see glowing crystals..diamonds!..arranged in the wall of the coral with points radially aimed at a glowing doughnut-shaped ring laying in the middle of the cave floor. ");

      Item egg = new Item ("egg", "Chrome-plated egg-shape device with ...Buttons!",
        "You pick it up and turn it over in your hands. You accidentally brush one of the buttons and are knocked into the cave wall from an explosion that occurred to your right.",
        "You eye the object with interest but decide to leave it lay. Searching the cave there doesn't appear to be any other opening. Suddenly you hear a whine coming from the device and a rocking explosion pushes you back.  On the cave wall appears to be an opening a few feet across in front of you. The device is no where to be seen.",
        false);

      Item red_rag = new Item ("red_rag", "Mysterious red cloth, flows like mercury, solidifies into weapon when you thwack it.",
        "Pointing the device at the far wall, you press the slide forward and a blackness pours out the tip and attaches to the coral.  A minute later a four-foot hole appears where the blackness attached to the coral. You head toward it.",
        "You let the red liquid settle to the floor.  Suddenly the red turns black and a white coral-encrusted skeletal arm reaches up, grabs your foot, and sucks you to hell. [YOU DIE, GAME OVER]",
        false);

      Item doughnut = new Item ("doughnut", "About 10 inches across, ring is 1.5 inches thick. Glows a neon light blue, pulsates.",
        "You reach down and examine the object.  While holding it firmly it glows more and pulls your whole body back through the cave rooms out the chasm and up to the waiting survey ship.  YOU FRICKING WIN!",
        "Suddenly the diamonds in the wall appear to be extending their points...rapidly...sharply...and impale you. YOU DIE!",
        false);

      //chasm.Items.Add (egg);
      cave1.Items.Add (egg);
      cave3.Items.Add (red_rag);
      cave4.Items.Add (doughnut);

      chasm.directions.Add("down", cave1);
      cave1.directions.Add("east", chasm);
      cave1.directions.Add("west", cave2);
      cave1.directions.Add("south", cave1);
      cave2.directions.Add("west", cave1);
      cave2.directions.Add("south", cave3);
      cave3.directions.Add("north", cave2);
      cave3.directions.Add("west", cave4);
      cave4.directions.Add("east", cave3);
      cave4.directions.Add("north", cave1);

      Room currentRoom = chasm;
      
      
 
     

      //TODO:  CONNECT THE DOTS, ETC.  DON'T FORGET WHAT DO YOU WANT TO DO ON EVERY SCREEN. INCLUDE QUIT WITH HELP, OPTIONS, 

    }
    public void Intro () {
      Console.Clear ();
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
      Console.Clear ();
      System.Console.WriteLine ($@"
                      /~~~~~~~~~~~~~~~~~~~~~/
                     / Surviving Vanuatu!  /
                    /~~~~~~~~~~~~~~~~~~~~~/ 

              HELP:  The Basic Features of the game:

      Use initial letters of each word. For example, 'Go East' you can type
      'ge', 'GE', etc. at the user prompt at the bottom.
	  
	  User input can be one or two letters. First two letters are checked.

    - <G>o <D>irection>` Moves the player from room to room, e.g. Go Down, type 'gd'
          Directions: <N>orth, <S>outh, <E>ast, <W>est, <D>own
	- <U>se <I>temName` Uses an item in a room or from your inventory
		Possible items: <E>gg, <R>ed rag, <D>oughnut, 
		
	- <T>ake <ItemName>` Places an item into the player inventory, 
		removes it from the room.  E.g., <T>ake <D>oughnut is 'TD'
		
	- <Q>uit` Quits the Game

	- <H>elp` List of commands. Redraws this screen
	- <L>ook` Re-prints the room description
	- <I>nventory` prints a list of the items in the players inventory
 
		When the player enters a room they get the room description

  ");
    }

    public void Prompt () {
      System.Console.WriteLine ($@"
  Make a move, Kid!__________  ");
    }
    public void UseItem (string itemName) {
    

    }
    public Game (Room currentRoom, Player currentPlayer) {
      this.CurrentRoom = currentRoom;
      this.CurrentPlayer = currentPlayer;

    }

  }
}