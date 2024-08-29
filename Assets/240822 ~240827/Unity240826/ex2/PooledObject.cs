using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public ObjectPool returnPool;

    [SerializeField] float returnTime; // 반납까지 걸리는 시각
    private float curTime; // 현재 시각

    private void OnEnable()
    {
        curTime = returnTime;
    }

    private void Update()
    {
        // = 업데이트가 이루어질 때마다, 시간이 차감된다.
        curTime -= Time.deltaTime;

        // = 시간이 다 차감되어 0이 되면, 함수 안으로 돌아간다.
        if (curTime < 0)
        {
            returnPool.ReturnPool(this);
        }
    }
}
