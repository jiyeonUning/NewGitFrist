using UnityEngine;

public class PositionMover : MonoBehaviour
{
    // < Position > - ������
    // ����Ƽ���� ������Ʈ�� ��ġ������ x, y, z 3������ �����Ǹ�, �ش� ���� Vetor3 Ŭ������ ���Ͽ� �����ϰ� �ٷ� �� �ִ�.
    // �ش� ������ ���� ���� ������Ʈ�� ��ġ �̵��� �������� �� �ִ�.

    [SerializeField] Transform target;
    [SerializeField] float moveSpeed;
    [SerializeField] int frame;

    private Vector3 startPosition;
    [Range(0, 1)]
    [SerializeField] float rate;

    // =================================================

    private void Start()
    {
        Application.targetFrameRate = frame;
        startPosition = transform.position;
    }

    void Update()
    {
        Debug.Log("Update");
        TranslateMove();
    }

    // ==================================================

    private void PositionMove()
    {
        // ���� ������ ���Ͽ� �̵��ϴ� ���
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }

    private void TranslateMove()
    {
        // Position ��İ� ��� ����
        // x, y, z���� ������ ��� �Լ�:Translate�� ����, �ش簪�� �������� �Ͽ� �̵��ϴ� ���
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void MoveTowardMove()
    {
        // ������������ - ��ǥ��������, �ش��ϴ� �ð���ŭ ������ �ӵ��� ���� ���� �� �ִ� �Լ� MoveTowards
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }

    private void LerpMove()
    {
        // ������������ - ��ǥ���������� ������ ����ϰ�, �Ÿ��� ���� ������ �̵� & ��ǥ������ ����������� �̵��ӵ��� ���� �ٿ��� �� �ִ� �Լ� Lerp
        transform.position = Vector3.Lerp(transform.position, target.position, rate * Time.deltaTime);
    }
}
