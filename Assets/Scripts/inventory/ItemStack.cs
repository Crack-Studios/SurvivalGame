using System.Collections.Generic;

namespace inventory
{
    [System.Serializable]
    public class ItemStack : Item
    {
        public int count;
        public string name;
        public List<string> description;
        
        public ItemStack(int ID, string Name, Dictionary<string, object> ItemData = null)
        {
            this.id = ID;
            this.name = Name;
            this.data = ItemData;
        }
        public ItemStack(int ID, string Name, int count, Dictionary<string, object> ItemData = null, List<string> desc = null)
        {
            this.id = ID;
            this.name = Name;
            this.data = ItemData;
            this.count = count;
            this.description = desc;
        }
        
        public ItemStack(int ID, string Name, int count)
        {
            this.id = ID;
            this.name = Name;
            this.count = count;
        }

        public ItemStack(int ID, string Name, int count, List<string> desc)
        {
            this.id = ID;
            this.name = Name;
            this.count = count;
            this.description = desc;
        }
        
        
    }
}