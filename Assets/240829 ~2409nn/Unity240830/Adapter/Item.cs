using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{
    public void Interact(Player player) { Use(); }

    public void Use()
    {
        Debug.Log("������ ���");
        Destroy(gameObject);
    }
}
