using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Item : IItem {
    public Item (string name, string description) {
      this.Name = name;
      this.Description = description;

    }
    public string Name { get; set; }
    public string Description { get; set; }
  }
}