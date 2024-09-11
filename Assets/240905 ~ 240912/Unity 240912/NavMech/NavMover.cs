using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// �ʿ��� ������ ������ ������ ���ִ� ��Ʈ����Ʈ �ڵ�
[RequireComponent(typeof(NavMeshAgent))]
public class NavMover : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

    private void Awake()
    {
        // ���� ���� �� �ڵ����� ���������� �� �ִ� �ڵ�
        agent = GetComponent<NavMeshAgent>();
    }

    // =================================================

    // ��ǥ��ġ
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
            // Ÿ���� ��ġ�� �÷��̾��� ��ǥ�������� ����
            // ��������� ���� ��� �ڵ��̹Ƿ�, �ڷ�ƾ���� �ڵ带 �����ִ� ���� ��õ
            agent.destination = target.position;
            yield return delay;
        }
    }
}
