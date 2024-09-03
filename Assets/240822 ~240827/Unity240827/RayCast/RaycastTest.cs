using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] Transform muzzlePoint; // �������� ��� �������� ��ġ
    [SerializeField] float maxDistance; // �������� �ִ� �Ÿ�

    // =======================================================================
    //                   �ѱ����� �������� �� �� �ִ� �ڵ�

    // ����ĳ��Ʈ�� ��ȯ�� : bool��
    private void Update()
    {
        // ����ĳ��Ʈ�� �ν��ϰ� �ִ� ������ �ð������� ��Ÿ�� �� �ְ� ���ִ� �Լ� DrawRay
        // �� â������ ���̳�, ���� â������ ������ �ʴ´�.

        if  // = �΋H�� ��ü�� ���� ��
        // Physics.Raycast(��� ��ġ, ��� ����, �΋H���� ���� ����( = RaycastHit ), �ִ�Ÿ�)
        // �΋H���� ���� ������ ������ �� �ִ� �Լ� RaycastHit            
            (Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance))
        {
            Debug.Log($"{hit.collider.gameObject.name}�� �΋H����. �ش� ��ü���� �Ÿ��� {hit.distance}m �̴�.");
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * hit.distance, Color.red);

        }
        else  // = �΋H�� ��ü�� ���� ��
        {
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * 100, Color.red);
        }
    }
}
