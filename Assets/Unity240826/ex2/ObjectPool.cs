using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // < ������ ���� : ������Ʈ Ǯ ���� >
    //    ���α׷� ������ ����ϰ� ��Ȱ���ϴ� �ν��Ͻ����� 'Ǯ'�� ������ ��
    // -> �ν��Ͻ��� ����&���� ���, �뿩&�ݳ��� ����ϴ� ���.

    // < ������ >
    // 1. �ν��Ͻ����� ������ 'Ǯ'�� �����Ѵ�.
    // 2. ���α׷��� ���� ��, 'Ǯ'�� �ν��Ͻ����� �����Ͽ� �����Ѵ�.
    // 3. �ν��Ͻ� ������ �ʿ��� ��, 'Ǯ'���� �뿩�Ͽ��� ������ش�.
    // 4. �ν��Ͻ� ������ �ʿ��� ��, 'Ǯ'�� ���� �ݳ��Ͽ� �����صд�.

    // < ������ >
    // 1. 
    // 2. ������Ʈ Ǯ �� ������ ���������� �پ��� ������ ���α׷��� �δ��� �Ǵ� ��찡 �ִ�.





    [SerializeField] List<PooledObject> pool = new List<PooledObject>();
    [SerializeField] PooledObject prefab;
    [SerializeField] int size;

    void Awake()
    {
        for (int i = 0; i < size; i++)
        {
            PooledObject instance = Instantiate(prefab);
            instance.gameObject.SetActive(false);
            instance.transform.parent = transform;
            instance.returnPool = this;
            pool.Add(instance);
        }
    }

    // Ǯ�� ������ ���� �뿩�ϴ� �Լ�
    public PooledObject GetPool(Vector3 position, Quaternion rotation)
    {
        if (pool.Count > 0)
        {
            PooledObject instance = pool[pool.Count - 1];
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.transform.parent = null;
            instance.returnPool = this;
            instance.gameObject.SetActive(true);


            pool.RemoveAt(pool.Count - 1);

            return instance;
        }
        else
        {
            PooledObject instance = Instantiate(prefab, position, rotation);
            return instance;
        }
    }

    // �뿩�� ���� �ٽ� �ݳ��ϴ� �Լ�
    public void ReturnPool(PooledObject instance)
    {
        instance.gameObject.SetActive(false);
        instance.transform.parent = transform;
        pool.Add(instance);
    }
}
