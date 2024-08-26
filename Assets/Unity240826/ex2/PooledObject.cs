using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public ObjectPool returnPool;

    [SerializeField] float returnTime; // �ݳ����� �ɸ��� �ð�
    private float curTime; // ���� �ð�

    private void OnEnable()
    {
        curTime = returnTime;
    }

    private void Update()
    {
        // = ������Ʈ�� �̷���� ������, �ð��� �����ȴ�.
        curTime -= Time.deltaTime;

        // = �ð��� �� �����Ǿ� 0�� �Ǹ�, �Լ� ������ ���ư���.
        if (curTime < 0)
        {
            returnPool.ReturnPool(this);
        }
    }
}
