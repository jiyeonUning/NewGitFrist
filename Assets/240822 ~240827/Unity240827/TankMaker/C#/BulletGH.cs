using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGH : MonoBehaviour
{
    [SerializeField] PooledObjectGH pooledObject;
    [SerializeField] float MoveSpeed;
    [SerializeField] float returnTime; // 총알을 풀에 반납하는 데 까지 걸리는 시간

    private float remainTime; // 총알을 생성한 시간

    void OnEnable()
    {
        remainTime = returnTime;
    }

    void Update()
    {
        // 앞으로 이동할 수 있는 기능 구현
        transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime, Space.Self);

        // 일정시간이 지나면, 다시 풀에 반납해줄 수 있는 if문을 작성
        remainTime -= Time.deltaTime;
        if (remainTime < 0) { pooledObject.ReturnPool(); }
    }

    // ===================================================================================
    //           총알이 다른 오브젝트와 부딫혔을(=충돌했을 때) 때의 상황 코드 

    // 충돌체와 닿았을 때 ( = 충돌체와 부딫혔을 때 )
    private void OnCollisionEnter(Collision collision)
    {
        // 플레이어와 닿았다면 데미지를 주고 반납
        if (collision.gameObject.name == "PlayerPhysical")
        {
            Debug.Log("플레이어를 공격!");
            pooledObject.ReturnPool();
        }
        // 다른 물체와 충돌하였다면 그냥 반납
        else
        {
            Debug.Log("다른 물체와 충돌함");
            pooledObject.ReturnPool();
        }
    }
}
