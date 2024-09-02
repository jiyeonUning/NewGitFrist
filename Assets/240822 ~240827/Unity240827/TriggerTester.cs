using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTester : MonoBehaviour
{
    // ������Ʈ�� �ٸ� ��ü���� �浹 �� ��ħ ���θ� �Ǵ����� �� �ִ� �Լ���
    // =====================================================================================
    //                                    ~ �⺻ ���� ~

    // Conllider = � �浹ü�� ��Ҵ� ���� ���� �������� ���Ѵ�.

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"������ �浹ü : {other.gameObject.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"�ӹ����� �ִ� �浹ü : {other.gameObject.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"�������� �浹ü : {other.gameObject.name}");
    }

    // ======================================================================================
}
