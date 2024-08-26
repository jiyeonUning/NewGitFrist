using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    [SerializeField] GameObject tankPrefab;
    [SerializeField] Rigidbody rigidPrefab;
    [SerializeField] Rigidbody targetRigid;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // <����>
            // Instantiate (������ ������Ʈ, ���� ��ġ) =  ()�� �ش��ϴ� ������Ʈ�� �ش��ϴ� ��ġ�� �����Ѵ�.
            GameObject instance = Instantiate(tankPrefab, transform.position, transform.rotation);
            instance.name = "������ ������Ʈ�� �̸��� �������� �� �ִ�.";

            // ������ٵ� ���� ������Ʈ�� ���� �����ϸ鼭, ������ �� ���� ������ ƨ�ܳ����� �ϴ� ��� �ڵ�
            Rigidbody rigid = Instantiate(rigidPrefab, transform.position, transform.rotation);
            rigid.AddForce(Vector3.forward * 7, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //<�ı�>
            // Destroy (������ ������Ʈ) = ()�� �ش��ϴ� ������Ʈ�� �����Ѵ�. 
            Destroy(tankPrefab, 2); // �ش��ϴ� ������Ʈ �ڿ� ���ڸ� ���̸�, �ش��ϴ� �ʸ�ŭ ������ �� ���������� �� �ִ�.
        }
    }
}
