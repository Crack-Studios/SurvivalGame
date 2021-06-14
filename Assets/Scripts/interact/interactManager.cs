using System;
using System.Collections;
using System.Collections.Generic;
using interact;
using UnityEngine;
using UnityEngine.UI;

public class interactManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    [Range(0.1f, 100f)]
    public float interactDist;

    public Text screenText;

    public inventory.inventory inv;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        IInteractable interactor;
        if (Physics.Raycast(cam.transform.position,cam.transform.forward, out hit, interactDist))
        {
            interactor = hit.collider.gameObject.GetComponent<IInteractable>();
            if (interactor != null && inv.isOpen == false)
            {
                interactor.Looking();
                screenText.text = interactor.LookText();
                if (interactor.IsInteractable())
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        interactor.OnInteract();
                    }
                }
                else
                {
                    screenText.text = "";
                    return;
                }
            }
        }
        else
        {
            screenText.text = "";
        }
    }
}
