using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionTester : MonoBehaviour
{
    // ������ٵ� ���� �浹�� �����ϴ� �Լ���
    //========================================================================================
    //                                    ~ �⺻ ���� ~

    // Conllision = �浹�� ���õ� �������� ���Ѵ�.

    // �浹�Ǿ��� ��(=�浹�� �������� ��) ����Ǵ� �Լ� OnCollisionEnter
    private void OnCollisionEnterTest(Collision collision)
    {
        Debug.Log($"�΋H�� �浹ü : {collision.gameObject.name}");
        
        // ���� if�� : �΋H�� �浹ü�� �̸��� " "�� �̸��� ���� ��,
        // Ư�� �ڵ�(ex:����������, ƨ�ܳ��� ��...)�� �����ų �� �ִ�.
        if (collision.gameObject.name == "Tank Orgin")
        {
            Debug.Log($"�÷��̾� �΋H�� ��, �Ѿ��� �÷��̾�� �������� �ش�.");
            // �÷��̾�� �΋H���� ��, ����� ���Ǹ� ���� �Ѿ��� �������.
            Destroy(gameObject);
        }
    }

    // �浹�ϴ� ���� ��(=�浹ü�� ���� ��� �´������ ��) ����Ǵ� �Լ� OnCollisionStay
    private void OnCollisionStayTest(Collision collision)
    {
        Debug.Log($"�΋H���� �ִ� �浹ü : {collision.gameObject.name}");
    }

    // �浹�� ������ ��(=�浹ü�� �������� ��) ����Ǵ� �Լ� OnCollisionExit
    private void OnCollisionExitTest(Collision collision)
    {
        Debug.Log($"�΋H���� ���� �浹ü : {collision.gameObject.name}");
    }

    //========================================================================================
}
