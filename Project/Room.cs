using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Room : IRoom {
    public Room (string name, string description) {
      this.Name = name;
      this.Description = description;

    }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }

    public void UseItem (Item item) {
      throw new System.NotImplementedException ();
    }
  }
}