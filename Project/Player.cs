using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Player : IPlayer {
    

    public Player (int score) {
      Score = score;
      Inventory = new List<Item>();

    }

    
    public int Score { get; set; }
    public List<Item> Inventory { get; set; }
  }
}