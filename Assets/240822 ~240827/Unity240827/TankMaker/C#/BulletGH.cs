using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGH : MonoBehaviour
{
    [SerializeField] PooledObjectGH pooledObject;
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

    // ===================================================================================
    //           �Ѿ��� �ٸ� ������Ʈ�� �΋H����(=�浹���� ��) ���� ��Ȳ �ڵ� 

    // �浹ü�� ����� �� ( = �浹ü�� �΋H���� �� )
    private void OnCollisionEnter(Collision collision)
    {
        // �÷��̾�� ��Ҵٸ� �������� �ְ� �ݳ�
        if (collision.gameObject.name == "PlayerPhysical")
        {
            Debug.Log("�÷��̾ ����!");
            pooledObject.ReturnPool();
        }
        // �ٸ� ��ü�� �浹�Ͽ��ٸ� �׳� �ݳ�
        else
        {
            Debug.Log("�ٸ� ��ü�� �浹��");
            pooledObject.ReturnPool();
        }
    }
}
