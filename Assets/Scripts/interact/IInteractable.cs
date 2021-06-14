namespace interact
{
    /// <summary>
    /// Interactable object.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>
        /// Checks if an object is interactable.
        /// </summary>
        /// <returns>Retruns a boolean about if the object is interactable.</returns>
        bool IsInteractable();
        /// <summary>
        /// The text showed under the pointer when looking at the object.
        /// </summary>
        /// <returns>Returns a string that will be displayed under the pointer.</returns>
        string LookText();
        /// <summary>
        /// Called when player is looking at the object.
        /// </summary>
        void Looking();
        /// <summary>
        /// Called when an object gets interacted with.
        /// </summary>
        void OnInteract();

        


    }
}