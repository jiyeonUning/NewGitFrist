using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    void Update()
    {
    }

    private void Write()
    {
        // < ������ ���� >
        // �۷ι� �����̽� = ��������
        // ���� �����̽�   = �����¿� (���α���)

        // ������ ����(�۷ι� �����̽�)���� �̵� = Space.World / �ڽ��� ����(���� �����̽�)���� �̵� = Space.Self
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        // ������ ����(�۷ι� �����̽�)���� ȸ�� = Space.World / �ڽ��� ����(���� �����̽�)���� ȸ�� = Space.Self
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }
}
