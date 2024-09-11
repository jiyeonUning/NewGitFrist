using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    [SerializeField] PlayerInput input;
    [SerializeField] Rigidbody rigid;

    [SerializeField] float movePower;
    [SerializeField] float jumpPower;

    private void Update()
    {
        // IsPressd = GetKey
        // WasPressedthisFrame = GetKeyDown
        // WasReleasedthisFrame = GetKeyUp

        // 인풋 시스템을 통항 움직임 세팅
        Vector2 move = input.actions["Move"].ReadValue<Vector2>();
        Vector3 dir = new Vector3(move.x, 0, move.y);
        rigid.AddForce(dir * movePower, ForceMode.Force);
        /* velocity 구현 코드 예제
            Vector2 move = input.actions["Move"].ReadValue<Vector2>();
            Vector3 dir = new Vector3(move.x, 0, move.y);
            rigid.velocity = dir * movePower + Vector3.up * rigid.velocity.y;
         */

        // 인풋 시스템을 통한 점프 세팅
        bool jump = input.actions["Jump"].WasPressedThisFrame();
        if (jump) { rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);  }
    }
}
