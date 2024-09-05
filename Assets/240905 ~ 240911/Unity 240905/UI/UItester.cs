using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UItester : MonoBehaviour
{

    public void Test()
    {
        // EventSystem.current.Select ~ 로 이벤트 시스템을 찾을 수 있다.
        Debug.Log("테스트");
    }
}
