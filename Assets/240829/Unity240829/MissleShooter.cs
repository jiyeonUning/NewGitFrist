using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleShooter : MonoBehaviour
{
    // 총알 연사기능 제작

    [SerializeField] GameObject misslePrefab;
    [SerializeField] float repeatTime;

    private Coroutine missleSpawnRoutine;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            missleSpawnRoutine = StartCoroutine(MissleSpawnRoutine());
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(missleSpawnRoutine);
        }
    }

    IEnumerator MissleSpawnRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(repeatTime);

        while (true)
        {
            Instantiate(misslePrefab, transform.position, transform.rotation);
            yield return delay;
        }
    }
}
