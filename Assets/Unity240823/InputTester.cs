using UnityEngine;

public class InputTester : MonoBehaviour
{
    // ����Ƽ �Է� : ����Ƽ���� ������� ����� ������ �� �ִ� ����.
    //               ����ڴ� �ܺ� ��ġ�� �̿��Ͽ� ������ ������ �� �ִ�.
    //               ����Ƽ�� �پ��� Ÿ���� �Է±�⸦ �����ϰ� �ִ�. (Ű����, ���콺, ���̽�ƽ ��)

    // ==============================================================================================

    void Update() { InputManagerUse();  }


    private void Device()
    {
        // < Device > ����̽� : Ư���� ��ġ�� ��������, �Է��� �����Ѵ�.
        //                ���� : Ư���� ��ġ�� �Է��� �����ϱ� ������, ���� �÷����� ������ ��ƴ�.


        // Ű���� �Է� ����
        if (Input.GetKey(KeyCode.Space)) // ������ �ִ� ���� true
        {
            Debug.Log("GetKey");
        }
        if (Input.GetKeyDown(KeyCode.Space)) // ������ �� true 
        {
            Debug.Log("GetKeyDown");
        }
        if (Input.GetKeyUp(KeyCode.Space)) // ���� �� true 
        {
            Debug.Log("GetKeyUp");
        }

        // ���콺 �Է� ����
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
        // < InputManager > �Է¸Ŵ��� : ���� ��ġ�� �Է��� -> �Է¸Ŵ����� �̸�&�Է��� �����Ѵ�.
        //                               �Է¸Ŵ����� �̸����� ������ �Է��� ��������� Ȯ���Ѵ�.
        //                               Edit - Settings - Input Manager ���� ������ �� �ִ�.
        // ��, ����Ƽ ��â���� ����� �״�� �̾������Ƿ�
        // Ű����, ���콺, ���̽�ƽ�� ���� ��ġ���� ����� �� �ִ�.


        // ��ư �Է�
        // Fire1 : Ű����(Left ctrl), ���콺(Left button), ���̽�ƽ(Button0)���� �����Ͽ���.
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

        // �� �Է�
        // Horizontal (����) : Ű���� A, D,  ��, �� / ���̽�ƽ (���� �Ƴ��α׽�ƽ �¿�) ���� ���ǵǾ� �ִ�.
        float x = Input.GetAxis("Horizontal");
        // Vertical (����) : Ű���� W, S, ��, �� / ���̽�ƽ (���� �Ƴ��α׽�ƽ ����) ���� ���ǵǾ� �ִ�.
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

    // �Է¸Ŵ����� Ȱ���Ͽ� �̵�&ȸ���� ������ �����ڵ� ù��°
    // �۵���� : �����¿�� �ش��ϴ� �������� ��ġ�̵��� ����
    //            ��ġ�̵� ��, �ոӸ��� �ش� �������� ȸ���ϰ� �Ѵ�
    private void InputManagerUse()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(x, 0, z);
        if (moveDir == Vector3.zero) return;

        // �̵� ����
        // normalized = � �������� ���� �ӵ��� �����ϰ� ���ش�.
        transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.World); 

        // ȸ�� ����
        // LookRotation = ���Ͱ��� ���� ��, �ش��ϴ� �������� ���ϰ� ���ش�.
        Quaternion lookRot = Quaternion.LookRotation(moveDir);
        // Lerp�Լ��� ����Ͽ�, ȸ������ �����Ͽ� ���� ���⿡�� ~ �ش��ϴ� ���������� �̵� ������ �ڿ������� ������� �� �־���.  
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRot, rate * Time.deltaTime);
        // or
        // RotateTowards�Լ��ε� ������ �����ϴ�.
        // transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, rotateSpeed);
    }


    // �Է¸Ŵ����� Ȱ���Ͽ� �̵�&ȸ���� ������ �����ڵ� �ι�°
    // �۵���� : ���� �Է� �� �ش��ϴ� �������� ��ġ�̵� ����
    //            �¿츦 �Է��ϸ� �ش��ϴ� �������� ������Ʈ�� ȸ��
    private void InputManagnerUseTwo()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // ������ ���� ���
        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime, Space.Self);
        // ȸ�� ���
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime, Space.World);
    }

    // ===========================================================================================

}
