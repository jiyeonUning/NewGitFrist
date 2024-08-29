using UnityEngine;

public class GameObjectTester : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Transform trans;
    [SerializeField] Rigidbody rigid;
    [SerializeField] Collider coll;

    void Start()
    {
        Debug.Log($"������ ���� ������Ʈ�� �̸� : {target.name}");
        target.name = "��ũ";
    }


    private void Write() // <������Ʈ ������Ʈ ����> : ����Ƽ ������ �����ϴ� �޼���.
                         // Ư�� ������Ʈ�� ���� ������Ʈ�� ������ �� �ֵ��� �� �� �ִ�.
    {
        // GetComponent = �ش� ������Ʈ�� ����� Ÿ��<T>�� ������Ʈ�� ��ȯ�Ѵ�.
        // ������Ʈ�� ���� �� ���� ����, ���� ù ��°�� �߰��� ������Ʈ �ϳ��� ��ȯ�Ѵ�.
        // �ش� Ÿ�Կ� ������Ʈ�� �������� �ʴ´ٸ�, null�� ��ȯ�Ѵ�.
        gameObject.GetComponent<Collider>();

        // GetComponents = �ش� ������Ʈ�� ����� Ÿ��<T>�� ��� ������Ʈ�� �迭�� ��ȯ�Ͽ� ���� �����´�.
        // �ش� Ÿ�Կ� ������Ʈ�� �������� �ʴ´ٸ�, �� �迭�� ��ȯ�Ѵ�.
        gameObject.GetComponents<Collider>();

        // GetComponentInChildren = �ش� ������Ʈ��, �� ������Ʈ�� �ڽ��� ��ȸ�ϸ鼭
        //                       -> ����� Ÿ��<T>�� ������Ʈ�� ��ȯ�Ѵ�.
        // ������Ʈ�� ���� �� ���� ����, ���� ù ��°�� �߰��� ������Ʈ �ϳ��� ��ȯ�Ѵ�.
        // �ش� Ÿ�Կ� ������Ʈ�� �������� �ʴ´ٸ�, null�� ��ȯ�Ѵ�.
        gameObject.GetComponentInChildren<Collider>();

        // GetComponentsInChildren = �ش� ������Ʈ��, �� ������Ʈ�� �ڽĵ��� ��ȸ�ϸ鼭
        //                        -> ����� Ÿ��<T>�� ��� ������Ʈ�� �迭�� ��ȯ�Ͽ� ���� �����´�.
        // �ش� Ÿ�Կ� ������Ʈ�� �������� �ʴ´ٸ�, �� �迭�� ��ȯ�Ѵ�.
        gameObject.GetComponentsInChildren<Collider>();

        // GetComponentInParent = �ش� ������Ʈ��, �� ������Ʈ�� �θ���� ��ȸ�ϸ鼭
        //                     -> �����Ÿ��<T>�� ������Ʈ�� ��ȯ�Ѵ�.
        // ������Ʈ�� ���� �� ���� ����, ���� ù ��°�� �߰��� ������Ʈ �ϳ��� ��ȯ�Ѵ�.
        // �ش� Ÿ�Կ� ������Ʈ�� �������� �ʴ´ٸ�, null�� ��ȯ�Ѵ�.
        gameObject.GetComponentInParent<Collider>();

        // GetComponentsInParent = �ش� ������Ʈ��, �� ������Ʈ�� �θ���� ��ȸ�ϸ鼭
        //                     -> ����� Ÿ��<T>�� ��� ������Ʈ�� �迭�� ��ȯ�Ͽ� ���� �����´�.
        // �ش� Ÿ�Կ� ������Ʈ�� �������� �ʴ´ٸ�, �� �迭�� ��ȯ�Ѵ�.
        gameObject.GetComponentsInParent<Collider>();
    }

}
