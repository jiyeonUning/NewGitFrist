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

        // ��ǲ �ý����� ���� ������ ����
        Vector2 move = input.actions["Move"].ReadValue<Vector2>();
        Vector3 dir = new Vector3(move.x, 0, move.y);
        rigid.AddForce(dir * movePower, ForceMode.Force);
        /* velocity ���� �ڵ� ����
            Vector2 move = input.actions["Move"].ReadValue<Vector2>();
            Vector3 dir = new Vector3(move.x, 0, move.y);
            rigid.velocity = dir * movePower + Vector3.up * rigid.velocity.y;
         */

        // ��ǲ �ý����� ���� ���� ����
        bool jump = input.actions["Jump"].WasPressedThisFrame();
        if (jump) { rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);  }
    }
}
