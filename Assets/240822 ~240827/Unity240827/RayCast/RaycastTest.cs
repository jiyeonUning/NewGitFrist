using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] Transform muzzlePoint; // �������� ��� �������� ��ġ
    [SerializeField] float maxDistance; // �������� �ִ� �Ÿ�
    [SerializeField] LayerMask layerMask; // ���̾� ����ũ : ���̾ ���� �浹�� ������Ʈ�� �浹���� �ʴ� ������Ʈ�� �����ϴ� ���� ����� ������ �� �ִ�.


    // ==============================================================================================================
    //                                       �ѱ����� �������� �� �� �ִ� �ڵ�

    // ����ĳ��Ʈ�� ��ȯ�� : bool��
    private void Update()
    {
        if  
        // Physics.Raycast(��� ��ġ, ��� ���� / �΋H���� ���� ����( = RaycastHit ), �ִ�Ÿ�, ���̾��ũ(=Ÿ�ٱ׷�))
        // �΋H���� ���� ������ ������ �� �ִ� �Լ� RaycastHit            
            (Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance, layerMask))
        {
            // = �΋H�� ��ü�� ���� ��
            Debug.Log($"{hit.collider.gameObject.name}�� �΋H����. �ش� ��ü���� �Ÿ��� {hit.distance}m �̴�.");

            // ����ĳ��Ʈ�� �ν��ϰ� �ִ� ������ �ð������� ��Ÿ�� �� �ְ� ���ִ� �Լ� Debug.DrawRay
            // �� â������ ���̳�, ���� â������ ������ �ʴ´�.
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * hit.distance, Color.green);

        }
        else  
        {   // = �΋H�� ��ü�� ���� ��
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * 100, Color.red);
        }
    }

    // ==============================================================================================================
    //                                                ~  �����   ~

    // �׻� ǥ���ϴ� ����� �Լ� OnDrawGizmos
    private void OnDrawGizmosTest()
    {
        // �ش��ϴ� ������� ���� �ٲ��� �� �ִ�.
        Gizmos.color = Color.green;
        // DraWire( ~ ) : ������ ��ġ��, ( ~ )����� ����� ������� �� �ִ�.
        Gizmos.DrawWireSphere(transform.position,10f);
    }

    // �����Ͽ��� �� ǥ�õǴ� ����� �Լ� OnDrawGizmoSelected
    private void OnDrawGizmosSelectedTest()
    {
        // �ش��ϴ� ������� ���� �ٲ��� �� �ִ�.
        Gizmos.color = Color.yellow;
        // DraWire ~ : �ش��ϴ� ��ġ�� 
        Gizmos.DrawWireSphere(transform.position, 10f);
    }

    // ==============================================================================================================
    //                                                ~  ���̾� �浹   ~


}
