using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverGH : MonoBehaviour
{
    [SerializeField] ObjectPoolGH[] bulletPool; // �Ѿ��� ���� ����
    private ObjectPoolGH curBulletPool; 
    [SerializeField] Transform muzzlePoint; // �Ѿ��� ������ ��ġ

    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    private void Awake()
    {
        // �ʱ� �Ѿ��� ������ 1������ �����Ͽ���.
        curBulletPool = bulletPool[0];
    }

    void Update()
    {
        // ��ũ ������ ����
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime);

        // �����̽��ٸ� ���� �Ѿ� �߻�
        if (Input.GetKeyDown(KeyCode.Space)) { Fire(); }

        // 1, 2, 3���� ���� �Ѿ��� ��ü���ִ� if��
        if (Input.GetKeyDown(KeyCode.Alpha1)) { SwapBullet(0); }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) { SwapBullet(1); }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) { SwapBullet(2); }
    }


    void Fire()
    {
        // ������ �Ѿ��� muzzlePoint���� �����Ѵ�.
        curBulletPool.GetPool(muzzlePoint.position, muzzlePoint.rotation);
    }

    void SwapBullet(int num)
    {
        // �ϳ��� ������ �迭 �ϳ��� �ִ� ������ �Ѿ��� ������ �������� �� �ִ�.
        curBulletPool = bulletPool[num];
    }
}
