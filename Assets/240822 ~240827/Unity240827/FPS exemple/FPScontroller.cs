using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontroller : MonoBehaviour
{
    [SerializeField] Transform camTransform; // ī�޶��� ��ġ,ȸ����
    [SerializeField] float rotateSpeed;      // ���콺�� �ΰ���
    [SerializeField] float moveSpeed;        // �÷��̾��� �̵��ӵ�

    //================================================================================
    private void Start()
    {
        // Ŀ���� ��ġ�� ȭ�� ������ ������ �ʵ���, �׻� ���߾����� ���� �� �ִ� �ڵ带 �ۼ�
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Move();
        // ��Ŭ�� �� �Ѿ��� ������ �� �ִ� if�� ����
        if (Input.GetMouseButtonDown(0)) { Fire(); }
        // ��Ŭ�� �� ȭ�� ȸ���� �����ϰ� �ϴ� if�� ����
        if (Input.GetMouseButton(1) == false) return;
        Look();
    }

    //================================================================================
    // �÷��̾� ������ �Լ�
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * x * moveSpeed * Time.deltaTime);
    }
    //================================================================================
    // �÷��̾� ī�޶� ȸ�� �Լ�
    void Look()
    {
        float x = Input.GetAxis("Mouse X"); // ���콺 �¿� �����ӷ�
        float y = Input.GetAxis("Mouse Y"); // ���콺 ���� �����ӷ�

        transform.Rotate(Vector3.up, rotateSpeed * x * Time.deltaTime);
        camTransform.Rotate(Vector3.right, rotateSpeed * -y * Time.deltaTime);
    }
    //================================================================================
    // �Ѿ� ���� �Լ�
    void Fire()
    {
        // ���� ī�޶� ���� �ִ� ��ġ����, ī�޶� �չ������� �������� �� ��
        if (Physics.Raycast(camTransform.position, camTransform.forward, out RaycastHit hit))
        {
            GameObject instnace = hit.collider.gameObject;
            // Ÿ���� ������Ʈ�� ������,
            TargetScript target = instnace.GetComponent<TargetScript>();

            // Ÿ���� ���� 0�� �ƴҶ�, ��, Ÿ���� ���� ����ִٸ� 
            if (target != null)
            {
                // Ÿ���� ������ Ÿ���� ���δ�.
                target.TakeHit();
            }
        }

    }
}
