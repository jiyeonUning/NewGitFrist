using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReceiver : MonoBehaviour
{
    // ����Ƽ �ν����� â���� ��ü������ ��������, �̺�Ʈ�� ������ �� �����ϰ� �� �� �ִ� �ڵ�
    // ��������� �����ϰ�, �ش� ����� ���� ������Ʈ�� -> �̺�Ʈ �ν����Ϳ� �巡���Ͽ� ������ų �� �ִ�.

    [SerializeField] Rigidbody rigid;
    public void Jump(float power)
    {  rigid.AddForce(Vector3.up * power, ForceMode.Impulse); }


    /* c# event�� Ȱ���Ͽ� �� ��ü�� ��ȣ�ۿ��� �� �ֵ��� �� �ڵ�
       �̺�Ʈ �߻� ��, ������� Ȱ��ȭ �ϴ� �ڵ带 �ۼ��Ͽ���. 

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
