using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// ����Ƽ �޽��� �Լ�(�̺�Ʈ �Լ�) : ����Ƽ�� ������ �޼����� �����ϴ� �Լ�.

// < ���� ���� >
// 1. MonoBehaviour Ŭ������ �޽����� ���� �̸��� �Լ��� ����
// 2. ��ũ��Ʈ�� ����Ƽ ������ ������ �޽����� �޾�, ��� Ÿ�̹��� Ȯ��
// 3. �޽��� �Լ����� �ڽ��� �ൿ�� �����Ͽ� ����� ����

public class Unity240822 : MonoBehaviour
{
    // �Լ��� ����� ����Ƽ �޽��� �Լ��� ��� �ۼ� 
    private void Awake() // =�غ�
    {
        // �����ũ : ��ũ��Ʈ�� ���� ���ԵǾ��� ��, 1ȸ ȣ���
        //            ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��쿡�� ȣ��ȴ�.
        //     ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �۾��� �ʱ�ȭ �ϴ� �۾��� �����Ѵ�. (�ܺ� ���� ��Ȳ�� ������ �ʱ�ȭ �۾�)
        Debug.Log("�����ũ");    
    }

    void Start() // =����
    {
        // ��ŸƮ : ��ũ��Ʈ�� ���� ó������ ������Ʈ �ϱ� ������, 1ȸ ȣ���
        //          ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��쿡�� ȣ����� �ʴ´�
        //   ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �۾��� �����Ѵ�. (�ܺ� ���ӻ�Ȳ�� �ʿ��� �ʱ�ȭ �۾�)
        Debug.Log("����");
    }

    private void OnEnable() // =Ȱ��ȭ
    {
        // ���ο��̺� : ��ũ��Ʈ�� Ȱ��ȭ�� �� ���� ȣ��
        //       ���� : ��ũ��Ʈ�� Ȱ��ȭ �Ǿ��� �� �۾��� �����Ѵ�.
        Debug.Log("Ȱ��ȭ");
    }

    private void OnDisable() //=��Ȱ��ȭ
    {
        // �µ��̺� : ��ũ��Ʈ�� ��Ȱ��ȭ �� �� ���� ȣ��
        //       ���� : ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��� �� �۾��� �����Ѵ�.
        Debug.Log("��Ȱ��ȭ");
    }

    void Update() // =����
    {
        // ������Ʈ : ������ �������� ȣ�����ش�.
        //     ���� : �ٽ� ���� ������ �������ش�. ���� ���߿��� ��� ����ȴ�.
        Debug.Log("����");
    }

    private void OnDestroy() // =������ �۾�
    {
        // �µ������ : ��ũ��Ʈ�� ������ �����Ǿ��� ��, 1ȸ ȣ��
        //         ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� ������ �۾��� �����Ѵ�.
        Debug.Log("������ �۾�");
    }

    private void LateUpdate()
    {
        // ����Ʈ������Ʈ : ������ ������ ���������� ȣ��ȴ�.
        // ���� ��� ���ӿ�����Ʈ�� ������Ʈ�� ����� �� �����Ѵ�.
    }

    private void FixedUpdate()
    {
        // �Ƚ��������Ʈ : ���� �ۼ�
    }


    //=================================================================

    // ����ȭ : ������ ����, �Ǵ� ���ӿ�����Ʈ ���¸� ����&���� �ϴ� ���.
    //          �ν����� â���� ������Ʈ�� ����ȭ�� ������� ���� �����ش�.
    //          �̸� �̿��Ͽ�, �ҽ��ڵ��� ���� ���� ����Ƽ �����Ϳ��� ���� ������ �����ϴ�.

    // <������ ����ȭ>
    // ������Ʈ�� �⺭���� ���� Ȯ�� or �������� �� �ִ�.
    // ������Ʈ�� ������� ������ �巡��&��� ������� �������� �� �ִ�.


    [Header("Value Tpye")]
    // C# Ÿ��
    public bool boolValue;
    public int inValue;
    public float floatValue;
    public string stringValue;

    // ����Ƽ Ÿ��
    public Vector3 vector3; // = x��, y��, z���� �����ϴ� ������
    public Vector3 vector2; // = x��, y�ุ �����ϴ� ������
    public Vector3Int intVector3;
    public Vector2Int intVector2;
    public Color color;

    public Rect rect;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;

    // ������
    public enum JobType { Warrioror, Mage, Rogue }
    public JobType jobType;

    // �迭 ��� �ڷᱸ��
    public int[] array;
    public List<int> list;

    // ����
    public Rigidbody rigid;
    public Collider Collider;


    // < ��Ʈ����Ʈ > : Ŭ����, �Ӽ� �Ǵ� �Լ� ���� ����Ͽ�, Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ.
    [Space(30)]
    [Header("Referance Tpye")] // = �������� �����͸� �����ش�.
    [SerializeField] private int privateValue; // = private �� �ν����Ϳ� ��������ش�.
    [HideInInspector] public int puvlicValue; // public �̴��� �ν����Ϳ��� �����ش�.

    [Range(3, 5)]
    public float percent; // = ���� ������ �� ��ŭ �����̵�� �������� �� �ִ�.

    [TextArea(3, 5)]
    public string story; // = �ѹ��� ���̴� ������� �����ϰ�, �� �̻��� �Ѿ�� �����̵�� �Ѿ�� ���� �� �ִ�.

    [System.Serializable]
    public struct Data // = ����ü�� �ۼ��� �������� ���� �������� �� �ִ�.
    {
        public string name;
        public int level; 
        public float rate;
    }
    public Data data;

    [System.Serializable]
    public class ClassTpye // Ŭ������ ����
    {
        public string Name;
        public int Level;
        public float Rate;
    }
    public ClassTpye classType;

    // ȸ�� �޸�
    [SerializeField] float rotateSpeed;
    [SerializeField] float yRotate;
    [SerializeField] float xRotate;
    [SerializeField] Quaternion target;

    void RotateTest()
    {
        // 1. ���� ���ؼ� ������ ȸ��
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // 2. �������� �������� ȸ��
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        // 3. ��ǥ ��ġ�� �ٶ󺸵��� ȸ��
        transform.LookAt(Vector3.zero);

        // 4. ȸ�� �������� �־��༭ ȸ��
        transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);

        // 5. �������� ȸ��
        transform.rotation = Quaternion.LookRotation(Vector3.right);

        // 6. ó������ �����ٰ�, �������鼭 ȸ��
        transform.rotation = Quaternion.Lerp(transform.rotation, target, 3 * Time.deltaTime);

        // 7. ��ǥȸ������ ���������� ȸ��
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, rotateSpeed * Time.deltaTime);

    }
}
