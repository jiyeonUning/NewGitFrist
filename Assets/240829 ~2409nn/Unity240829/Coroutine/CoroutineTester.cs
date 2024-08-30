using System.Collections;
using UnityEngine;

public class CoroutineTester : MonoBehaviour
{

    // < 코루틴 - Coroutine >
    // 유니티에서 함수의 실행을 일시중지하고, 나중에 다시 이어서 실행할 수 있는, 직렬적으로 일을 처리하는 동기 작업의 개념.

    // 일반함수의 반환형, return 대신 yield 키워드를 사용한다.
    // yield 키워드를 사용 시, 사용이 일시중지되고 -> 다른 코드를 실행 or 유니티에게 제어권을 반납하고, 다음 실행 시 중단점부터 이어서 실행할 수 있다.

    //==================================================================================================================================================

    // < 주의점 > : 사용이 끝나면 반드시 중지해줄 것
    //              코루틴 실행 시, 클래스 객체가 생성되어 메모리에 할당된다.
    // 이를 별도로 해제하지 않는 상태로 반복&누적이 될 경우, 메모리 누수가 발생할 수 있으므로 주의가 필요하다.

    //==================================================================================================================================================

    // < 해결법 > : 코루틴을 변수에 담아 사용하는 것
    //              코루틴 실행 시, 클래스 객체에 생성되므로 -> 힙 메모리에 클래스 인스턴스가 할당된다.
    //    주기적으로 실행되어야 하는 코루틴의 경우,
    //    변수를 선언하여 미리 힙에 할당해놓고 ~ 해당 변수에 생성되는 코루틴 객체를 할당하는 방식
    //    ㄴ 해당 방식을 사용한다면, 메모리 공간을 절양하며 사용할 수 있어 메모리 단편화를 방지할 수 있다.

    //==================================================================================================================================================

    private void Start()
    {
        Coroutine coroutine = StartCoroutine(BulletCreateRoutine());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 담당자가 null, 즉, 없었을 때 실행되는 if문
            if (delayJumpCoroutione == null)
            { delayJumpCoroutione = StartCoroutine(DelayJump()); }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            // 담당자가 값이 있는, 즉, 존재할 때 실행되는 if문
            if (delayJumpCoroutione != null)
            {
                // ()의 코루틴을 멈추는 함수 StopCoroutine
                StopCoroutine(delayJumpCoroutione);
                delayJumpCoroutione = null;
            }
        }
    }

    // ===========================================================================

    // 총알을 3초마다 생성해주는 함수
    [SerializeField] float bulletTime;
    IEnumerator BulletCreateRoutine()
    {
        while (true)
        {
            // 해당 코드를 통해, 작업을 일시중지한 후
            yield return new WaitForSeconds(bulletTime);
            // ()의 값만큼 초가 지나면 다음 함수를 실행한다.
            Debug.Log("총알 생성");
        }
    }

    // ===========================================================================



    // 동작 도중, 점프키를 누르면 딜레이 후 점프하는 기능
    [SerializeField] Rigidbody rigid;
    private Coroutine delayJumpCoroutione;
    IEnumerator DelayJump()
    {
        Debug.Log(3);
        yield return new WaitForSeconds(1f);
        Debug.Log(2);
        yield return new WaitForSeconds(1f);
        Debug.Log(1);
        yield return new WaitForSeconds(1f);

        // 점프기능
        rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);

        // 점프기능 수행 시, 값을 null로 하여 다음 점프도 겹치지 않고 수행이 가능하게 한다.
        delayJumpCoroutione = null;
    }

    // ===========================================================================

    IEnumerator CoroutinWait()
    {
        //  < 코루틴 지연 > : 코루틴은 반복작업 중, 지연처리를 정의하여 -> 작업의 진행 타이밍을 지정할 수 있다.

        yield return null;                              // 한 프레임을 지연시킨다.
        yield return new WaitForSeconds(1f);            // n초 간, 시간을 지연시킨다.
        // ======================================================================================================
        yield return new WaitForSecondsRealtime(1f);    // 현실의 n초 간, 시간을 지연시킨다.
        yield return new WaitForFixedUpdate();          // FixedUpdate 함수가 실행될 때 까지 실행을 지연시킨다.
        yield return new WaitForEndOfFrame();           // 프레임의 끝까지 실행을 지연시킨다.
        yield return new WaitUntil(() => true);         // 조건이 충족이 될 때 까지 실행을 지연시킨다.
    }
}
