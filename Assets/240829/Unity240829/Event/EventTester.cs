using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{
    // 유니티 인스펙터 창에서 자체적으로 참조시켜, 이벤트가 생겼을 때 반응하게 할 수 있는 코드
    [SerializeField] float screamVolume; // Scream의 크기

    // public event UnityAction OnScream; 으로도 사용해줄 수 있다.
    // UnityEvent는 이름으로 참조값을 찾으므로, 속도가 느린 편이다.
    // UnityAction은 코드를 기반으로 참조값을 찾으므로, 속도가 빠른 것을 원한다면 해당 이벤트를 권장한다.
    public UnityEvent<float> OnScream;
    // <>를 통해, 매개변수를 통하여 이벤트를 실행시켜줄 수 있다.

    private void Update()
    {  if (Input.GetKeyDown(KeyCode.Space)) { Scream(); }  }

    void Scream()
    {
        Debug.Log("플레이어가 소리를 지릅니다!");
        OnScream?.Invoke(screamVolume); // 이벤트를 발생시킨다.
    }


    /* c# event를 활용하여 각 개체가 상호작용할 수 있도록 한 코드 
       이벤트를 만들고, 한 기능을 발생시키면 이벤트가 발생하도록 하는 코드를 작성하였다.

    public event Action OnScream;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { Scream(); }
    }

    void Scream()
    {
        Debug.Log("플레이어가 소리를 지릅니다!");
        OnScream?.Invoke(); // 이벤트를 발생시킨다.
    }
     
    */

}
