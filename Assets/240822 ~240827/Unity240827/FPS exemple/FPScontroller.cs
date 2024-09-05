using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontroller : MonoBehaviour
{
    [SerializeField] Transform camTransform; // 카메라의 위치,회전값
    [SerializeField] float rotateSpeed;      // 마우스의 민감도
    [SerializeField] float moveSpeed;        // 플레이어의 이동속도

    //================================================================================
    private void Start()
    {
        // 커서의 위치가 화면 밖으로 나가지 않도록, 항상 정중앙으로 해줄 수 있는 코드를 작성
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Move();
        // 좌클릭 시 총알을 발포할 수 있는 if문 구현
        if (Input.GetMouseButtonDown(0)) { Fire(); }
        // 우클릭 시 화면 회전이 가능하게 하는 if문 구현
        if (Input.GetMouseButton(1) == false) return;
        Look();
    }

    //================================================================================
    // 플레이어 움직임 함수
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * x * moveSpeed * Time.deltaTime);
    }
    //================================================================================
    // 플레이어 카메라 회전 함수
    void Look()
    {
        float x = Input.GetAxis("Mouse X"); // 마우스 좌우 움직임량
        float y = Input.GetAxis("Mouse Y"); // 마우스 상하 움직임량

        transform.Rotate(Vector3.up, rotateSpeed * x * Time.deltaTime);
        camTransform.Rotate(Vector3.right, rotateSpeed * -y * Time.deltaTime);
    }
    //================================================================================
    // 총알 발포 함수
    void Fire()
    {
        // 현재 카메라가 보고 있는 위치에서, 카메라 앞방향으로 레이저를 쏠 때
        if (Physics.Raycast(camTransform.position, camTransform.forward, out RaycastHit hit))
        {
            GameObject instnace = hit.collider.gameObject;
            // 타겟의 컴포넌트를 가져와,
            TargetScript target = instnace.GetComponent<TargetScript>();

            // 타겟의 값이 0이 아닐때, 즉, 타겟이 아직 살아있다면 
            if (target != null)
            {
                // 타겟을 삭제해 타겟을 죽인다.
                target.TakeHit();
            }
        }

    }
}
