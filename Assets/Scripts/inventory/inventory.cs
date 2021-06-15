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

        public ItemStack draggedItem;

        public int dragSlotStart;

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
            GUI.BeginGroup(new Rect(Event.current.mousePosition.x-16, Event.current.mousePosition.y-16, 32, 32));

            if (draggedItem.itemIcon)
            {
                GUI.DrawTexture(new Rect(0,0,32,32), draggedItem.itemIcon, ScaleMode.StretchToFill);
                
            }
            else
            {
                GUI.Label(new Rect(0,0,32,32), draggedItem.name);
            }

            GUIStyle style = new GUIStyle();
            style.alignment = TextAnchor.LowerRight;
            
            GUI.Label(new Rect(0,0,32,32), "x"+draggedItem.count.ToString(), style);
            
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


                    
                    GUI.BeginGroup(new Rect(i*36,24,32,32), new GUIContent("","Item name: "+invItems[i].name+"\n\nDescription:\n"+String.Join("\n",invItems[i].description)));
                    
                    
                    
                    
                    GUI.DrawTexture(new Rect(0,0,32,32), slotTexture, ScaleMode.StretchToFill);
                    if (invItems[i].itemIcon != null)
                    {
                        GUI.DrawTexture(new Rect(0,0,32,32), invItems[i].itemIcon);
                    }
                    else
                    {
                        GUI.Label(new Rect(0,0,32,32),invItems[i].name);
                    }
                    
                    Event e = Event.current;
                   // Debug.Log(draggedItem.name);
                    //Debug.Log(invItems[i].id);
                    if (e.type == EventType.MouseDown && draggedItem.id == 0 && invItems[i].id != 0)
                    {
                        
                        Debug.Log("ELFOGATTA");
                        draggedItem = invItems[i];
                        dragSlotStart = i;
                        invItems[i] = itemReg.Items[0];
                        
                    }

                    if (e.type == EventType.MouseUp && draggedItem.id != 0 && invItems[i].id == 0)
                    {
                        
                        
                        Debug.Log("gfofoaa");
                            
                        invItems[i] = draggedItem; 
                        draggedItem = itemReg.Items[0];
                        
                    }
                    
                    GUIStyle style = new GUIStyle();
                    style.alignment = TextAnchor.LowerRight;
            
                    GUI.Label(new Rect(0,0,32,32), "x"+invItems[i].count.ToString(), style);
                
                    GUI.EndGroup();
                
                
                
                }
                
                GUI.EndGroup();
                
                GUI.Box(new Rect(Screen.width-275, 1, 256, 512),new GUIContent()); 
                GUI.Label(new Rect(Screen.width-275, 1, 256, 512), GUI.tooltip);
                
                Event ee = Event.current;
                if (ee.type == EventType.MouseUp && draggedItem.id != 0)
                {
                        
                        
                    
                            
                    invItems[dragSlotStart] = draggedItem; 
                    draggedItem = itemReg.Items[0];
                        
                }
                
                RenderDraggedItem();
            }
            
            
        }

        
    }
}
