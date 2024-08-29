using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTwo : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }

    public void SetSpeed(float speed) // ���� ������ �� �ֵ��� �����ڸ� ����
    { this.speed = speed; }
}
