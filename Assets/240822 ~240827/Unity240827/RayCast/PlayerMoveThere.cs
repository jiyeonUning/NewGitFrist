using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveThere : MonoBehaviour
{
    [SerializeField] Vector3 destination; // ������ ���� ���� �������� ��ġ�� �ľ��Ѵ�
    [SerializeField] float moveSpeed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
        // or Lerp �Լ� ���
        // transform.position = Vector3.Lerp(transform.position, destination, moveSpeed * Time.deltaTime);
    }

    public void Move(Vector3 destination)
    {
        // �����ؿ� ���� ����� �� �ְ� �Ѵ�.
        this.destination = destination;
    }
}
