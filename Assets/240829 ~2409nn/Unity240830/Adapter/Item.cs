using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{
    public void Interact(Player player) { Use(); }

    public void Use()
    {
        Debug.Log("아이템 사용");
        Destroy(gameObject);
    }
}
