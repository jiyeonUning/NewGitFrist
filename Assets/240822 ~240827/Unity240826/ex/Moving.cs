using UnityEngine;

public class Moving : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float rate;
    [SerializeField] float rotateSpeed;

    void Update()
    {
        InputManagnerUseTwo();
    }

    void InputManagnerUseTwo()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(x, 0, z);
        if (moveDir == Vector3.zero) return;

        // 회전 구현
        // LookRotation = 백터값을 받은 후, 해당하는 방향으로 향하게 해준다.
        Quaternion lookRot = Quaternion.LookRotation(moveDir);
        // Lerp함수를 사용하여, 회전률을 보간하여 지금 방향에서 ~ 해당하는 방향으로의 이동 과정을 자연스럽게 만들어줄 수 있었다.  
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRot, rate * Time.deltaTime);
    }
}


