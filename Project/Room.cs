using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Room : IRoom {
    public Room (string name, string description) {
      this.Name = name;
      this.Description = description;

    }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; } = new List<Item> ();
    public Dictionary<string, Room> directions = new Dictionary<string, Room> ();

    public Item UseItem (string itemName) {
      Item useItem = Items.Find (i => i.Name == itemName);
      if (useItem != null) {
        Items.Remove (useItem);
      }
      return useItem;
    }

    public void GetDescription () {
      System.Console.WriteLine($@"
      -------------------------
        {Name}
      -------------------------
      ");
      System.Console.WriteLine (Description);     
      System.Console.WriteLine("there are exits to the....");
      System.Console.WriteLine (String.Join (", ", directions.Keys));

    }

    public Item TakeItem (string itemName) {
      Item foundItem = Items.Find (i => i.Name == itemName);
      Console.Clear ();
      System.Console.WriteLine ($@"
            You have taken the item!
            
            {foundItem.Description}         
                                    ");

      return foundItem;
    }
  }
}