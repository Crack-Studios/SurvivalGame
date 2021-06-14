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
        /// The item's name.
        /// </summary>
        public string name;

        /// <summary>
        /// Constructor for the Item object.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="ItemData"></param>
        public Item(int ID, string Name, Dictionary<string, object> ItemData = null)
        {
            this.data = ItemData;
            this.id = ID;
            this.name = Name;
        }

        public Item()
        {
            this.data = null;
            this.id = -1;
            this.name = "NOTNAMED";
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