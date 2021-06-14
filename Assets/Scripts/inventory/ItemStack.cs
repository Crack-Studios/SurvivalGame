using System.Collections.Generic;

namespace inventory
{
    [System.Serializable]
    public class ItemStack : Item
    {
        public int count;
        public ItemStack(int ID, string Name, Dictionary<string, object> ItemData = null)
        {
            this.id = ID;
            this.name = Name;
            this.data = ItemData;
        }
        public ItemStack(int ID, string Name, int count, Dictionary<string, object> ItemData = null)
        {
            this.id = ID;
            this.name = Name;
            this.data = ItemData;
            this.count = count;
        }
        
        public ItemStack(int ID, string Name, int count)
        {
            this.id = ID;
            this.name = Name;
            this.count = count;
        }
        
        
    }
}