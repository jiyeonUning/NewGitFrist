using UnityEngine;

public class PositionMover : MonoBehaviour
{
    // < Position > - 포지션
    // 유니티에서 오브젝트의 위치정보는 x, y, z 3축으로 구성되며, 해당 값은 Vetor3 클래스를 통하여 간편하게 다룰 수 있다.
    // 해당 원리를 통해 게임 오브젝트의 위치 이동을 구현해줄 수 있다.

    [SerializeField] Transform target;
    [SerializeField] float moveSpeed;
    [SerializeField] int frame;

    private Vector3 startPosition;
    [Range(0, 1)]
    [SerializeField] float rate;

    // =================================================

    private void Start()
    {
        Application.targetFrameRate = frame;
        startPosition = transform.position;
    }

    void Update()
    {
        Debug.Log("Update");
        TranslateMove();
    }

    // ==================================================

    private void PositionMove()
    {
        // 값에 방향을 더하여 이동하는 기능
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }

    private void TranslateMove()
    {
        // Position 방식과 기능 같음
        // x, y, z축의 정보가 담긴 함수:Translate를 통해, 해당값을 기준으로 하여 이동하는 기능
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void MoveTowardMove()
    {
        // 시작지점에서 - 목표지점까지, 해당하는 시간만큼 일정한 속도로 가게 해줄 수 있는 함수 MoveTowards
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }

    private void LerpMove()
    {
        // 시적지점에서 - 목표지점까지의 비율을 계산하고, 거리에 따라 빠르게 이동 & 목표지점에 가까워질수록 이동속도를 점점 줄여줄 수 있는 함수 Lerp
        transform.position = Vector3.Lerp(transform.position, target.position, rate * Time.deltaTime);
    }
}
