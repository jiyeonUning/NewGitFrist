using UnityEngine;

public class RotationMover : MonoBehaviour
{
    // <Rotation> - �����̼�
    // �ν������� Ʈ������ ������Ʈ������ ȸ������ �����ǰ� �����ϰ� x, y, z������ ����������, ���� ������ 4���Ҹ� ����ϴ� ���ʹϾ��� ���� �̷������.
    // = �̴� ����ӵ��� ������, 3���� ������� ���� ������ ����*�� �����ϴµ��� ȿ�����̴�.

    // ��, ���ʹϾ��� ���������� ȿ������ �ݸ� ������ �����ϱ� ����� �����̹Ƿ�,
    // ���� ��������, 3������ ��Ʈ�� �� �� �ֵ��� QuaternionŬ����-Euler�Լ��� ����� �� �� �ִ�.

    // *������ ���� : �� ���� ȸ���� �ٸ� ���� ȸ���� ������ �ָ�, �� ���� ȸ������ ���� �ǵ�ġ �ʰ� �� �� �̻��� ���� ��ġ�� �Ǹ� -> �� ���� ȸ������ �ҽǵǴ� ����.


    [SerializeField] float rotateSpeed;
    [SerializeField] float angle;

    [SerializeField] Transform target;

    // =======================================

    void Update()
    {
        RotationRotate();
    }

    // ======================================

    private void RotationRotate()
    {
        // ���� ���� ȸ���ϱ� (���� ����)
        angle += rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, rotateSpeed * angle, 0);
    }

    private void RotateRotate()
    {
        // ���� ���� ȸ���ϱ� (������ ����)
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    private void RotateAroundRotate()
    {
        // �������� �߽����� ȸ���ϱ�
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void LookAtRotate()
    {
        // �������� ��� �ٶ󺸵��� ȸ���ϱ�
        transform.LookAt(target.position);
    }
}
