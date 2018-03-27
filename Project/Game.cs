using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Game : IGame {
    public Game (Room currentRoom, Player currentPlayer) {
      this.CurrentRoom = currentRoom;
      this.CurrentPlayer = currentPlayer;

    }
    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public void Reset () {

    }

    public void Setup () {

    }

    public void UseItem (string itemName) {

    }
  }
}