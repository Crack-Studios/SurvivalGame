using System.Collections;
using System.Collections.Generic;
using inventory;
using UnityEngine;

public class ItemRegistry : MonoBehaviour
{
    

    public List<ItemStack> Items;
    
    // Start is called before the first frame update

    
    void Start()
    {
        ItemStack item = new ItemStack(0,"Air");
        item.showIcon = false;
        Items.Add(item);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
