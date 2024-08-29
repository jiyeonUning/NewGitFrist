using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOne : MonoBehaviour
{
    [SerializeField] PooledObjectOne pooledObject;
    [SerializeField] float MoveSpeed;
    [SerializeField] float returnTime; // �Ѿ��� Ǯ�� �ݳ��ϴ� �� ���� �ɸ��� �ð�

    private float remainTime; // �Ѿ��� ������ �ð�

    void OnEnable()
    {
        remainTime = returnTime;
    }

    void Update()
    {
        // ������ �̵��� �� �ִ� ��� ����
        transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime, Space.Self);

        // �����ð��� ������, �ٽ� Ǯ�� �ݳ����� �� �ִ� if���� �ۼ�
        remainTime -= Time.deltaTime;
        if (remainTime < 0) { pooledObject.ReturnPool(); }
    }
}
