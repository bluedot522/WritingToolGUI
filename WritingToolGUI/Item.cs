using System;
using System.Collections.Generic;
using System.Text;

namespace WritingToolGUI
{
    public class Item
    {
        public static List<string> itemType = new List<string>();
        public static List<Item> itemsTotal = new List<Item>();

        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public List<string> Tags
        {
            get; set;
        }

        public string Date
        {
            get; set;
        }
        public virtual void CreateNew()
        {

        }

        public static void Edit(Item item, string name, string description, List<string> tags)
        {
            item.Name = name;
            item.Description = description;
            item.Tags = tags;
        }
        public virtual void Delete()
        {
        }
    }
}
