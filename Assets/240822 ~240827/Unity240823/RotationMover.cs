using UnityEngine;

public class RotationMover : MonoBehaviour
{
    // <Rotation> - 로테이션
    // 인스펙터의 트렌스폼 컴포넌트에서는 회전값이 포지션과 동일하게 x, y, z축으로 보여지지만, 내부 동작은 4원소를 사용하는 쿼터니언을 통해 이루어진다.
    // = 이는 연산속도가 빠르고, 3축을 사용했을 때의 짐벌락 현상*을 방지하는데에 효과적이다.

    // 단, 쿼터니언은 연산적으로 효과적인 반면 아직은 이해하기 어려운 개념이므로,
    // 보다 직관적인, 3축으로 컨트롤 할 수 있도록 Quaternion클래스-Euler함수를 사용해 줄 수 있다.

    // *짐벌락 현상 : 한 고리의 회전이 다른 고리의 회전에 영향을 주며, 이 고리외 회전으로 인해 의도치 않게 두 개 이상의 고리가 겹치게 되면 -> 한 축의 회전각이 소실되는 현상.


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
        // 축을 통해 회전하기 (값이 기준)
        angle += rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, rotateSpeed * angle, 0);
    }

    private void RotateRotate()
    {
        // 축을 통해 회전하기 (각도가 기준)
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    private void RotateAroundRotate()
    {
        // 기준점을 중심으로 회전하기
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void LookAtRotate()
    {
        // 기준점을 계속 바라보도록 회전하기
        transform.LookAt(target.position);
    }
}
