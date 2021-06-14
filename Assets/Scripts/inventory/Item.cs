using System.Collections.Generic;

namespace inventory
{
    [System.Serializable]
    public class Item
    {
        /// <summary>
        /// The item's data.
        /// </summary>
        public Dictionary<string, object> data;

        /// <summary>
        /// The item's id.
        /// </summary>
        public int id;

        

        /// <summary>
        /// Constructor for the Item object.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="ItemData"></param>
        public Item(int ID, Dictionary<string, object> ItemData = null)
        {
            this.data = ItemData;
            this.id = ID;
            
        }

        public Item()
        {
            this.data = null;
            this.id = -1;
            
        }

        /// <summary>
        /// Gets data from the item's data.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Returns an object from the Item's data, set by SETData.</returns>
        public object GETData(string key)
        {
            return data[key];
        }

        /// <summary>
        /// Sets the key element of the item's data, Can be retrieved by GETData.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>

        public void SETData(string key, object value)
        {
            data.Add(key, value);
        }



    }
}