using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    public void Interact(Player player) { Talk(); }

    public void Talk()
    {
        Debug.Log("NPC�� ��ȭ�� �մϴ�.");
    }
}
