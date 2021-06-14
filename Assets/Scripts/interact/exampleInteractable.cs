using UnityEngine;
using interact;

public class exampleInteractable : MonoBehaviour, IInteractable
{
    public bool IsInteractable()
    {
        return true;
    }
    

    public void Looking()
    {
        
    }

    public void OnInteract()
    {
        Destroy(this.gameObject);
    }

    public string LookText()
    {
        return "Example interactable! Will destroy itself on interact!";
    }
}