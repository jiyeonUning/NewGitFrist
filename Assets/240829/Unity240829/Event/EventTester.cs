using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{
    // ����Ƽ �ν����� â���� ��ü������ ��������, �̺�Ʈ�� ������ �� �����ϰ� �� �� �ִ� �ڵ�
    [SerializeField] float screamVolume; // Scream�� ũ��

    // public event UnityAction OnScream; ���ε� ������� �� �ִ�.
    // UnityEvent�� �̸����� �������� ã���Ƿ�, �ӵ��� ���� ���̴�.
    // UnityAction�� �ڵ带 ������� �������� ã���Ƿ�, �ӵ��� ���� ���� ���Ѵٸ� �ش� �̺�Ʈ�� �����Ѵ�.
    public UnityEvent<float> OnScream;
    // <>�� ����, �Ű������� ���Ͽ� �̺�Ʈ�� ��������� �� �ִ�.

    private void Update()
    {  if (Input.GetKeyDown(KeyCode.Space)) { Scream(); }  }

    void Scream()
    {
        Debug.Log("�÷��̾ �Ҹ��� �����ϴ�!");
        OnScream?.Invoke(screamVolume); // �̺�Ʈ�� �߻���Ų��.
    }


    /* c# event�� Ȱ���Ͽ� �� ��ü�� ��ȣ�ۿ��� �� �ֵ��� �� �ڵ� 
       �̺�Ʈ�� �����, �� ����� �߻���Ű�� �̺�Ʈ�� �߻��ϵ��� �ϴ� �ڵ带 �ۼ��Ͽ���.

    public event Action OnScream;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { Scream(); }
    }

    void Scream()
    {
        Debug.Log("�÷��̾ �Ҹ��� �����ϴ�!");
        OnScream?.Invoke(); // �̺�Ʈ�� �߻���Ų��.
    }
     
    */

}
