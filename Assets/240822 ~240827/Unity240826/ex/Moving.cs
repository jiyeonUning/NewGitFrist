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

        // ȸ�� ����
        // LookRotation = ���Ͱ��� ���� ��, �ش��ϴ� �������� ���ϰ� ���ش�.
        Quaternion lookRot = Quaternion.LookRotation(moveDir);
        // Lerp�Լ��� ����Ͽ�, ȸ������ �����Ͽ� ���� ���⿡�� ~ �ش��ϴ� ���������� �̵� ������ �ڿ������� ������� �� �־���.  
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRot, rate * Time.deltaTime);
    }
}


