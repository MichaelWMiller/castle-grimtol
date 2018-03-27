using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Game : IGame {
    public Game()
    {
    }


    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public void Reset () {

    }

    public void Setup () {

      //Set up rooms and descriptions
    
      Room chasm = new Room ("Chasm", "You are equipped for the long duration dive and are being lowered into inky blackness. Several minutes --and 40 feet into the dive with the stranded Cargador de Mar looming overhead--you glance down and see a phosphurescent glow below you getting brighter.");
      Room cave1 = new Room ("Cave1", "The glow is stronger and you are lowered even with a coral cave opening 10 feet across.  You shine your light and notice a shine off of an egg-shaped artifact near the north cave wall.");
      //use artifact: You pick it up and turn it over in your hands. You accidentally brush one of the buttons and are knocked into the cave wall from an explosion that occurred to your right.
      //don't use:  You eye the object with interest but decide to leave it lay. Searching the cave there doesn't appear to be any other opening. Suddenly you hear a whine coming from the device and a rocking explosion pushes you back.  On the cave wall appears to be an opening a few feet across in front of you. The device is no where to be seen.

      Room cave2 = new Room ("Cave 2", "After the debris settles and your vision clears, you see a small opening ");
      //use egg.  After you recovered you swim down to the floor and through the small opening. You are barely able to stand up, and you do, but suddenly a deep vibration can be felt and the cave ceiling comes crashing down [YOU'RE DEAD--GAME ENDS]
      // dont use egg
      Room cave3 = new Room ("Cave 3", "After the debris settles, your vision suddenly goes red.  You swipe at your face trying to clear your vision, then slap at your helmet.  A red object appears with a cylinder, a sharp point and a hand-grip. The cave is otherwise empty about 20 feet in diameter.");
      //use red cylinder:  Pointing the device at the far wall, you press the slide forward and a blackness pours out the tip and attaches to the coral.  A minute later a four-foot hole appears where the blackness attached to the coral. You head toward it.

      //don't use red cylinder:  You let the red liquid settle to the floor.  Suddenly the red turns black and a skeletal arm reaches up, grabs your foot, and sucks you to hell. [YOU DIE, GAME OVER]
      Room cave4 = new Room ("Cave 4", "After stowing the red mercury stuff in your bag, you enter the room to see glowing crystals..diamonds!..arranged in the wall of the coral with points radially aimed at a glowing doughnut-shaped ring laying in the middle of the cave floor. ");
      //use doughnut:  You reach down and examine the object.  While holding it firmly it glows more and pulls you through the cave rooms, and up to the waiting survey ship.  YOU FRICKING WIN!
      //DONT use doughnut: Suddenly the diamonds in the wall appear to be extending their points...rapidly...sharply...and impale you. YOU DIE!

      Item i1 = new Item ("egg", "Chrome-plated egg-shape device.",
      "You climb into the bed and pretend to be asleep. A few minutes later several guards walk into the room. One approaches you to wake you... (GUARD) Hey Get Up! it's your turn for watch, Go relieve Shigeru in the Guard Room.  Quickly you climb out of the bed", 
      "(GUARD) What do you think your doing? Hey your not Leroy, Quick Jenkins sieze him.... Jenkins a bit over-zelous swings his sword cleaving you in half... <DEATH MESSAGE>", 
      false);
      Item i2 = new Item ("perfume", "Used to spray a door", false);
      Item i3 = new Item ("sword", "Slays or smashes", false);
      Item i4 = new Item ("whatever", "Does whatever", false);

      hallway.Items.Add (i1);
    
    //TODO:  DRAW A MAP, INSTANTIATE DIRECTIONS, ITEM(S), GET THE STORY GOING.
    //TODO:  CONNECT THE DOTS, ETC.  DON'T FORGET WHAT DO YOU WANT TO DO ON EVERY SCREEN. INCLUDE QUIT WITH HELP, OPTIONS, 
    
    }

    public void UseItem (string itemName) {

    }
    public Game (Room currentRoom, Player currentPlayer) {
      this.CurrentRoom = currentRoom;
      this.CurrentPlayer = currentPlayer;

    }

  }
}