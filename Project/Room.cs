using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Room : IRoom {
    public Room (string name, string description) {
      this.Name = name;
      this.Description = description;

    }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items {get; set;} = new List<Item>();
    public Dictionary<string, string> directions = new Dictionary<string, string>();

    public void UseItem (Item item) {

      
    }
    public void TakeItem(Item item) {

    }
  }
}