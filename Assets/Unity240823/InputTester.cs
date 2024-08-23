using UnityEngine;

public class InputTester : MonoBehaviour
{
    // 유니티 입력 : 유니티에서 사용자의 명령을 감지할 수 있는 수단.
    //               사용자는 외부 장치를 이용하여 게임을 제어할 수 있다.
    //               유니티는 다양한 타입의 입력기기를 지원하고 있다. (키보드, 마우스, 조이스틱 등)

    // ==============================================================================================

    void Update() { InputManagerUse();  }


    private void Device()
    {
        // < Device > 디바이스 : 특정한 장치를 기준으로, 입력을 감지한다.
        //                단점 : 특정한 장치의 입력을 감지하기 때문에, 여러 플랫폼에 대응이 어렵다.


        // 키보드 입력 감지
        if (Input.GetKey(KeyCode.Space)) // 누르고 있는 동안 true
        {
            Debug.Log("GetKey");
        }
        if (Input.GetKeyDown(KeyCode.Space)) // 눌렀을 때 true 
        {
            Debug.Log("GetKeyDown");
        }
        if (Input.GetKeyUp(KeyCode.Space)) // 땠을 때 true 
        {
            Debug.Log("GetKeyUp");
        }

        // 마우스 입력 감지
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse left button is pressing");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse left button is down");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse left button is up");
        }
    }

    // ===========================================================================================

    private void InputManager()
    {
        // < InputManager > 입력매니저 : 여러 장치의 입력을 -> 입력매니저에 이름&입력을 정의한다.
        //                               입력매니저의 이름으로 정의한 입력의 변경사항을 확인한다.
        //                               Edit - Settings - Input Manager 에서 관리할 수 있다.
        // 단, 유니티 초창기의 방식이 그대로 이어졌으므로
        // 키보드, 마우스, 조이스틱에 대한 장치만을 고려할 수 있다.


        // 버튼 입력
        // Fire1 : 키보드(Left ctrl), 마우스(Left button), 조이스틱(Button0)으로 정의하였다.
        if (Input.GetButton("Fire1"))
        {
            Debug.Log("Fire1 is pressing");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1 is down");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Debug.Log("Fire1 is up");
        }

        // 축 입력
        // Horizontal (수평) : 키보드 A, D,  ←, → / 조이스틱 (왼쪽 아날로그스틱 좌우) 으로 정의되어 있다.
        float x = Input.GetAxis("Horizontal");
        // Vertical (수직) : 키보드 W, S, ↑, ↓ / 조이스틱 (왼쪽 아날로그스틱 상하) 으로 정의되어 있다.
        float y = Input.GetAxis("Vertical");

        if (x != 0)
        {
            Debug.Log($"Horizontal Axis {x}");
        }
        if (y != 0)
        {
            Debug.Log($"Vertical Axis {y}");
        }
    }

    [SerializeField] float moveSpeed;
    [SerializeField] float rate;
    [SerializeField] float rotateSpeed;

    // 입력매니저를 활용하여 이동&회전을 구현한 예제코드 첫번째
    // 작동방식 : 상하좌우로 해당하는 방향으로 위치이동이 가능
    //            위치이동 시, 앞머리가 해당 방향으로 회전하게 한다
    private void InputManagerUse()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(x, 0, z);
        if (moveDir == Vector3.zero) return;

        // 이동 구현
        // normalized = 어떤 방향으로 가든 속도가 일정하게 해준다.
        transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.World); 

        // 회전 구현
        // LookRotation = 백터값을 받은 후, 해당하는 방향으로 향하게 해준다.
        Quaternion lookRot = Quaternion.LookRotation(moveDir);
        // Lerp함수를 사용하여, 회전률을 보간하여 지금 방향에서 ~ 해당하는 방향으로의 이동 과정을 자연스럽게 만들어줄 수 있었다.  
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRot, rate * Time.deltaTime);
        // or
        // RotateTowards함수로도 구현이 가능하다.
        // transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, rotateSpeed);
    }


    // 입력매니저를 활용하여 이동&회전을 구현한 예제코드 두번째
    // 작동방식 : 상하 입력 시 해당하는 방향으로 위치이동 가능
    //            좌우를 입력하면 해당하는 방향으로 오브젝트를 회전
    private void InputManagnerUseTwo()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // 전진과 후진 기능
        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime, Space.Self);
        // 회전 기능
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime, Space.World);
    }

    // ===========================================================================================

}
