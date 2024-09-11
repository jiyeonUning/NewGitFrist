using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// 필요한 참조를 삭제할 수없게 해주는 어트리뷰트 코드
[RequireComponent(typeof(NavMeshAgent))]
public class NavMover : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

    private void Awake()
    {
        // 게임 시작 시 자동으로 참조시켜줄 수 있는 코드
        agent = GetComponent<NavMeshAgent>();
    }

    // =================================================

    // 목표위치
    [SerializeField] Transform target;

    private void Start()
    {
        StartCoroutine(MoveRoutine());
    }

    IEnumerator MoveRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(0.2f);
        while (true)
        {
            // 타겟의 위치를 플레이어의 목표지점으로 설정
            // 연산과정이 많이 드는 코드이므로, 코루틴으로 코드를 돌려주는 것을 추천
            agent.destination = target.position;
            yield return delay;
        }
    }
}
