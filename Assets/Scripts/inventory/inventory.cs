using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace inventory
{
    [System.Serializable]
    public class inventory : MonoBehaviour
    {
        public bool isOpen = true;

        public List<ItemStack> invItems;

        public Texture slotTexture;

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
                
                GUI.BeginGroup(new Rect(100,10,Screen.width-300,Screen.height-200));
                
                for (int i = 0; i < invItems.Count; i++)
                {
                    /*if (GUI.Button(new Rect(i*136,15,128,128), invItems[i].name))
                    {
                        Debug.Log(invItems[i].name + " :: PRESSED");
                    }*/

                
                
                    GUI.BeginGroup(new Rect(i*36,24,32,32), new GUIContent("","Item name: "+invItems[i].name+"\n\n\n"+String.Join("\n",invItems[i].description)));
                
                    GUI.DrawTexture(new Rect(0,0,32,32), slotTexture, ScaleMode.StretchToFill);
                    if (invItems[i].itemIcon)
                    {
                        GUI.DrawTexture(new Rect(0,0,32,32), invItems[i].itemIcon);
                    }
                    else
                    {
                        GUI.Label(new Rect(0,0,32,32),invItems[i].name);
                    }
                
                
                    GUI.EndGroup();
                
                
                
                }
                
                GUI.EndGroup();
                
                GUI.Box(new Rect(Screen.width-275, 1, 256, 512),new GUIContent()); 
                GUI.Label(new Rect(Screen.width-275, 1, 256, 512), GUI.tooltip);
            }
            
            
        }

        
    }
}
