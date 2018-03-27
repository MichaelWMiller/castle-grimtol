using System.Collections.Generic;

namespace CastleGrimtol.Project {
  public class Item : IItem {
       
    public string Name { get; set; }
    public string ItemUsedDescription { get; set;}
    public string ItemNotUsedDescription{get;set;}
    public bool ItemUsed{get; set;}
    public string Description { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public Item (string name, string description, string itemUsedDescription, string itemNotUsedDescription, bool itemUsed) {
      this.Name = name;
      this.Description = description;
      this.ItemUsedDescription = itemUsedDescription;
      this.ItemNotUsedDescription = itemNotUsedDescription;
      this.ItemUsed = itemUsed;
    }
  }
}