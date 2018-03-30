using System.Collections.Generic;
using System;

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

    public Item UseItem (string itemName) {
    
      Item useItem = Items.Find(i => i.Name == itemName);
      if (useItem.ItemUsed)
      {
        System.Console.WriteLine($@"
          Sorry, this item, the {useItem.Name},  has already been used...
        ");
      } else 
      {
        System.Console.WriteLine($@"
          You decide to use the item {useItem.Name}.
          
          Action:  {useItem.ItemUsedDescription}
        ");
        useItem.ItemUsed = false;
      }
      return useItem;
    }

    public Item TakeItem(string itemName) {
      Item foundItem = Items.Find(i => i.Name == itemName);
      Console.Clear();
       System.Console.WriteLine ($@"
            You have taken the item!
            
            {foundItem.Description}         
                                    ");
      
                                    
      
      return foundItem;
    }
  } 
}