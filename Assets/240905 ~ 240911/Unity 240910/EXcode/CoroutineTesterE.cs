using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTesterE : MonoBehaviour
{
    public string name;

    void Start()
    {
        StartCoroutine(Routine());
    }

    private void Update()
    {
        Debug.Log($"{name} ������Ʈ");
    }

    IEnumerator Routine()
    {
        yield return null;
        Debug.Log($"{name} �ڷ�ƾ");
    }
}
