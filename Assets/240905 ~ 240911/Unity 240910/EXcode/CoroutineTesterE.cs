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
        Debug.Log($"{name} 업데이트");
    }

    IEnumerator Routine()
    {
        yield return null;
        Debug.Log($"{name} 코루틴");
    }
}
