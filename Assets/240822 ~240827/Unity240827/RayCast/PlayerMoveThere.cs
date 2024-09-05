using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveThere : MonoBehaviour
{
    [SerializeField] Vector3 destination; // 참조한 값을 통해 목적지의 위치를 파악한다
    [SerializeField] float moveSpeed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
        // or Lerp 함수 사용
        // transform.position = Vector3.Lerp(transform.position, destination, moveSpeed * Time.deltaTime);
    }

    public void Move(Vector3 destination)
    {
        // 참조해온 값을 사용할 수 있게 한다.
        this.destination = destination;
    }
}
