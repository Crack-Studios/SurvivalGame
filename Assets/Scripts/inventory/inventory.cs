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

        public ItemRegistry itemReg;
        
        public ItemStack[] invItems = {new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air"),new ItemStack(0, "Air")};

        public Texture slotTexture;

        public ItemStack draggedItem = null;

        public void Start()
        {
            
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOpen = !isOpen;
            }
        }

        public void RenderDraggedItem()
        {
            GUI.BeginGroup(new Rect(Event.current.mousePosition.x-32, Event.current.mousePosition.y-32, 64, 64));
            
            
            
            GUI.EndGroup();
        }

        public void OnGUI()
        {
            if (isOpen)
            {
                
                GUI.BeginGroup(new Rect(100,10,Screen.width-325,Screen.height-200));
                GUI.Box(new Rect(0,0,Screen.width-325,Screen.height-200),new GUIContent()); 
                
                for (int i = 0; i < invItems.Length; i++)
                {
                    /*if (GUI.Button(new Rect(i*136,15,128,128), invItems[i].name))
                    {
                        Debug.Log(invItems[i].name + " :: PRESSED");
                    }*/


                    if (invItems[i] != null)
                    {
                        GUI.BeginGroup(new Rect(i*36,24,32,32), new GUIContent("","Item name: "+invItems[i].name+"\n\nDescription:\n"+String.Join("\n",invItems[i].description)));
                    }
                    else
                    {
                        GUI.BeginGroup(new Rect(i*36,24,32,32), new GUIContent(""));
                    }
                    
                    
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
                    if (e.type == EventType.MouseDown && draggedItem == null && invItems[i].id != 0)
                    {
                        
                        Debug.Log("ELFOGATTA");
                        draggedItem = invItems[i];
                        invItems[i] = null;
                        
                    }

                    if (e.type == EventType.MouseUp && draggedItem != null && invItems[i].id == 0)
                    {
                        
                        
                        Debug.Log("gfofoaa");
                            
                        invItems[i] = draggedItem; 
                        draggedItem = null;
                        
                    }
                
                    GUI.EndGroup();
                
                
                
                }
                
                GUI.EndGroup();
                
                GUI.Box(new Rect(Screen.width-275, 1, 256, 512),new GUIContent()); 
                GUI.Label(new Rect(Screen.width-275, 1, 256, 512), GUI.tooltip);
                
                RenderDraggedItem();
            }
            
            
        }

        
    }
}
