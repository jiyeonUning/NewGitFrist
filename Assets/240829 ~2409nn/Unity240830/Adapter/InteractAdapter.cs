using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractAdapter : MonoBehaviour, IInteractable
{
    public UnityEvent<Player> OnInteract;

    public void Interact(Player player) { OnInteract?.Invoke(player); }
}
