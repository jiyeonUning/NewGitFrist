using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    // Ÿ�ٿ� �Ѿ��� �¾��� ��, �ش� Ÿ���� ���ִ� �Լ�
    public void TakeHit()
    {
        Destroy(gameObject);
        // �ش� �Լ��� �ƴϴ���, ü���� ���δٰų� �ϴ� ������� �پ��� ����� ������ �� �ִ�.
    }
}
