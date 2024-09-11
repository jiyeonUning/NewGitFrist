using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ThreadTester : MonoBehaviour
{
    public string name;

    void Start()
    {
        Task.Run(ThreadFunc);
    }

    private void Update()
    {
        Debug.Log($"{name} 업데이트");
    }

    void ThreadFunc()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log($"{name} 쓰레드 {i}");
        }
    }
}
