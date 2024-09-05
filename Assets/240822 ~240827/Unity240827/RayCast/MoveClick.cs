using UnityEngine;

public class MoveClick : MonoBehaviour
{
    // < �ڵ� �ۼ� �� �˾Ƶθ� ���� ���� > : �ڵ����� �����ϱ�
    //         [ ��� �� ������ ]          : �±״� �� �ϳ��� �ִ� ������Ʈ���Ը� ������ִ� ���� ��õ
    //                          ã�� �ӵ��� ������, ��������� ���Ƽ� ��ǻ�Ϳ� ���ϰ� �ɸ�

    // �±װ� "MainCamera"�� ī�޶� ������Ʈ�� ������ �� �ִ� �ڵ� : Camera.main;
    // Ư�� �±׸� �� ���� ������Ʈ�� ������ �� �ִ� �Լ� : GameObject.FindGameObjectWithTag("(Ž���� �±��� �̸�)");

    // ==================================================================================================================
    // ==================================================================================================================
    //                                                  ~ ����� �� ��� ~

    //   ����â���� ���콺�� ��Ŭ�� �ϸ�, �ش� ��ġ�� �̵��ϴ� ĳ���� ���� ����
    // = ī�޶󿡼� �������� ���, �������� �ش��ϴ� ��ġ�� �΋H���� �̵��ϴ� ����� ����

    // ==================================================================================================================
    // ==================================================================================================================



    [SerializeField] Camera cam;                 // ī�޶� ������ ���
    [SerializeField] GameObject playerOBJ;       // ���� ������Ʈ�� ������ ���
    [SerializeField] PlayerMoveThere playermove; // �÷��̾ �̵��ϴ� ������Ʈ�� ������ ���



    private void Start()
    {
        // "MainCamera" �±׸� ���� ������Ʈ�� ���� ���� �� �ڵ����� ���������ش�.
        cam = Camera.main;
        // "Player" �±׸� ���� ������Ʈ�� ���� ���� �� �ڵ����� ���������ش�.
        playerOBJ = GameObject.FindGameObjectWithTag("Player");
        // GetComponent�� ���� �÷��̾� ������Ʈ�� �����´�.
        playermove = playerOBJ.GetComponent<PlayerMoveThere>();
    }

    private void Update()
    {
        // �̵��ϰ� ���� ��ġ�� ���� ���콺 ��Ŭ�� ��ư�� ������ ��, �̵��� �̷������ �ϴ� if��
        if (Input.GetMouseButtonDown(1)) { ClickMove(); }
    }

    void ClickMove()
    {
        // ī�޶󿡼� �ش��ϴ� ��ġ�� ���� ������(ray)�� ��ġ���� �����ϰ� ���� �� �ִ� �Լ� ScreemPointToRay
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        // �������� ��� �ٴ� ������Ʈ�� ����� ��,
        if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
        {
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red, 0.2f);
            // ���� ������ ��, �÷��̾� ������Ʈ�� ���� �������� �΋H�� ��ġ�� �̵��Ѵ�.
            Vector3 destination = hit.point;
            playermove.Move(destination);
        }
        // �׷��� ���� ��,
        else
        {
            // ����ĳ��Ʈ�� ����������, ��� �������� �󸶳� �������� ��� �� ������, �������� ��, �������� �� �� �� �����ϴ���
            //  ~ �� ���� �������� �ۼ��ϰ�, DrawRay�� ���� �������� �߻��Ѵ�.
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 0.2f);
        }

    }
}
