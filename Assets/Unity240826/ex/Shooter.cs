using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [Range(1, 10)]
    [SerializeField] float bulletSpeed;
    [SerializeField] Transform muzzlePoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { Fire(); }
    }

    public void Fire()
    {
        GameObject instance = Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation); // �Ѿ� ������ ����
        Bullet bullet = instance.GetComponent<Bullet>(); // �Ҹ��� ������Ʈ�� ������
        bullet.SetSpeed(bulletSpeed); // ���� �����Ǿ��ִ� �Ҹ��� �ӵ��� ���Ϳ��� ������ �Ҹ��� �ӵ��� �������ش�.
    }
}
