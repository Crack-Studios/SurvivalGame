using System;
using System.Collections.Generic;
using UnityEngine;

namespace inventory
{
    [System.Serializable]
    public class inventory : MonoBehaviour
    {
        public bool isOpen = true;

        public List<ItemStack> invItems;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOpen = !isOpen;
            }
        }

        public void OnGUI()
        {
            if (isOpen)
            {
                GUI.Window(0,new Rect(10,10,512,256),invWindowFunc, "Inventory");
            }
        }

        private void invWindowFunc(int winId)
        {
            //Debug.Log(ItemRegMan.items.Count);
            for (int i = 0; i < invItems.Count; i++)
            {
                /*if (GUI.Button(new Rect(i*136,15,128,128), invItems[i].name))
                {
                    Debug.Log(invItems[i].name + " :: PRESSED");
                }*/
                GUI.Label(new Rect(i*72,24,64,64),invItems[i].name);
            }
            GUI.DragWindow(new Rect(0,0,10000,10000));
        }
    }
}
