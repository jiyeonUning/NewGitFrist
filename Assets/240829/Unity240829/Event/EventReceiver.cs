using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReceiver : MonoBehaviour
{
    // 유니티 인스펙터 창에서 자체적으로 참조시켜, 이벤트가 생겼을 때 반응하게 할 수 있는 코드
    // 점프기능을 구현하고, 해당 기능을 가진 오브젝트를 -> 이벤트 인스펙터에 드래그하여 참조시킬 수 있다.

    [SerializeField] Rigidbody rigid;
    public void Jump(float power)
    {  rigid.AddForce(Vector3.up * power, ForceMode.Impulse); }


    /* c# event를 활용하여 각 개체가 상호작용할 수 있도록 한 코드
       이벤트 발생 시, 점프기능 활성화 하는 코드를 작성하였다. 

    [SerializeField] EventTester tester;
    [SerializeField] Rigidbody rigid;

    private void OnEnable()
    {
        tester.OnScream += Jump;
    }

    private void OnDisable()
    {
        tester.OnScream -= Jump;
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 8f, ForceMode.Impulse);
    }
     
    */

}
