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

        public ItemStack draggedItem = null;

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
                
                GUI.BeginGroup(new Rect(100,10,Screen.width-325,Screen.height-200));
                GUI.Box(new Rect(0,0,Screen.width-325,Screen.height-200),new GUIContent()); 
                
                for (int i = 0; i < invItems.Count; i++)
                {
                    /*if (GUI.Button(new Rect(i*136,15,128,128), invItems[i].name))
                    {
                        Debug.Log(invItems[i].name + " :: PRESSED");
                    }*/

                
                
                    GUI.BeginGroup(new Rect(i*36,24,32,32), new GUIContent("","Item name: "+invItems[i].name+"\n\nDescription:\n"+String.Join("\n",invItems[i].description)));
                    
                    GUI.DrawTexture(new Rect(0,0,32,32), slotTexture, ScaleMode.StretchToFill);
                    if (invItems[i].itemIcon)
                    {
                        GUI.DrawTexture(new Rect(0,0,32,32), invItems[i].itemIcon);
                    }
                    else
                    {
                        GUI.Label(new Rect(0,0,32,32),invItems[i].name);
                    }
                    
                    Event e = Event.current;
                    if (e.type == EventType.MouseDown)
                    {
                        Debug.Log("MIODONOIOO");
                        if (new Rect(i*36,24+10,32,32).Contains(e.mousePosition) && draggedItem == null)
                        {
                            Debug.Log("ELFOGATTA");
                            draggedItem = invItems[i];
                            invItems[i] = null;
                        }
                    }

                    if (e.type == EventType.MouseUp)
                    {
                        Debug.Log("MIOIPPO");
                        if (new Rect(100,10,Screen.width-325,Screen.height-200).Contains(e.mousePosition) && draggedItem != null)
                        {
                            Debug.Log("gfofoaa");
                            
                            invItems[i] = draggedItem;
                            draggedItem = null;
                        }
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
