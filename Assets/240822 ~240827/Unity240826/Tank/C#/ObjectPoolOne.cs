using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolOne : MonoBehaviour
{
    [SerializeField] PooledObjectOne prefab;
    [SerializeField] bool createOnEmpty = true;
    [SerializeField] int size;
    [SerializeField] int capacity;

    // �Ѿ��� ���� �� ��ŭ �����Ͽ� �����صδ� �뵵�� Ǯ �迭�� ����
    private Stack<PooledObjectOne> pool;

    void Awake()
    {
        // �Ѿ��� ���� Ǯ�� ����
        pool = new Stack<PooledObjectOne>(capacity);

        // Ǯ�� �Ѿ��� �����ϴ� for��
        for (int i = 0; i < size; i++)
        {
            PooledObjectOne instance = Instantiate(prefab);
            instance.gameObject.SetActive(false);
            instance.transform.parent = transform;
            instance.Pool = this;
            pool.Push(instance);
        }
    }

    // Ǯ�� ������ ���� �뿩�ϴ� �Լ�
    public PooledObjectOne GetPool(Vector3 position, Quaternion rotation)
    {
        if (pool.Count > 0) // Ǯ�� ������ �Ѿ��� ���� 0�� ��,
        {
            PooledObjectOne instance = pool.Pop();
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.gameObject.SetActive(true);
            return instance;
        }
        else if (createOnEmpty) // �Ѿ��� �뿩�ϰ� ���� ��,
        {
            PooledObjectOne instance = Instantiate(prefab);
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.Pool = this;
            return instance;
        }
        else
        {
            return null;
        }
    }

    // �뿩�� ���� �ٽ� �ݳ��ϴ� �Լ�
    public void ReturnPool(PooledObjectOne instance)
    {
        // �������� �Ѿ��� ���� �����Ϸ��� �Ѿ��� �� ���� ���� ��, ������ ���ߴ� if��
        if (pool.Count < capacity)
        {
            instance.gameObject.SetActive(false);
            pool.Push(instance);
        }
        else { Destroy(instance.gameObject); }
    }
}
