using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTester : MonoBehaviour
{
    // 오브젝트가 다른 물체와의 충돌 및 겹침 여부를 판단해줄 수 있는 함수들
    // =====================================================================================
    //                                    ~ 기본 개념 ~

    // Conllider = 어떤 충돌체와 닿았는 지에 대한 정보값을 지닌다.

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"진입한 충돌체 : {other.gameObject.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"머무르고 있는 충돌체 : {other.gameObject.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"빠져나간 충돌체 : {other.gameObject.name}");
    }

    // ======================================================================================
}
