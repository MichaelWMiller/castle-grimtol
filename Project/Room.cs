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
    public Dictionary<string, Room> directions = new Dictionary<string, Room>();

    public void UseItem (Item item) {

      
    }

    public Item TakeItem(string itemName) {
      var foundItem = Items.Find(i => i.Name == itemName);
      Items.Remove(foundItem);
      return foundItem;
    }
  }
}