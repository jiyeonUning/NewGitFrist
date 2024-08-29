using System.Collections;
using UnityEngine;

public class CoroutineTester : MonoBehaviour
{

    // < �ڷ�ƾ - Coroutine >
    // ����Ƽ���� �Լ��� ������ �Ͻ������ϰ�, ���߿� �ٽ� �̾ ������ �� �ִ�, ���������� ���� ó���ϴ� ���� �۾��� ����.

    // �Ϲ��Լ��� ��ȯ��, return ��� yield Ű���带 ����Ѵ�.
    // yield Ű���带 ��� ��, ����� �Ͻ������ǰ� -> �ٸ� �ڵ带 ���� or ����Ƽ���� ������� �ݳ��ϰ�, ���� ���� �� �ߴ������� �̾ ������ �� �ִ�.

    //==================================================================================================================================================

    // < ������ > : ����� ������ �ݵ�� �������� ��
    //              �ڷ�ƾ ���� ��, Ŭ���� ��ü�� �����Ǿ� �޸𸮿� �Ҵ�ȴ�.
    // �̸� ������ �������� �ʴ� ���·� �ݺ�&������ �� ���, �޸� ������ �߻��� �� �����Ƿ� ���ǰ� �ʿ��ϴ�.

    //==================================================================================================================================================

    // < �ذ�� > : �ڷ�ƾ�� ������ ��� ����ϴ� ��
    //              �ڷ�ƾ ���� ��, Ŭ���� ��ü�� �����ǹǷ� -> �� �޸𸮿� Ŭ���� �ν��Ͻ��� �Ҵ�ȴ�.
    //    �ֱ������� ����Ǿ�� �ϴ� �ڷ�ƾ�� ���,
    //    ������ �����Ͽ� �̸� ���� �Ҵ��س��� ~ �ش� ������ �����Ǵ� �ڷ�ƾ ��ü�� �Ҵ��ϴ� ���
    //    �� �ش� ����� ����Ѵٸ�, �޸� ������ �����ϸ� ����� �� �־� �޸� ����ȭ�� ������ �� �ִ�.

    //==================================================================================================================================================

    private void Start()
    {
        Coroutine coroutine = StartCoroutine(BulletCreateRoutine());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ����ڰ� null, ��, ������ �� ����Ǵ� if��
            if (delayJumpCoroutione == null)
            { delayJumpCoroutione = StartCoroutine(DelayJump()); }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            // ����ڰ� ���� �ִ�, ��, ������ �� ����Ǵ� if��
            if (delayJumpCoroutione != null)
            {
                // ()�� �ڷ�ƾ�� ���ߴ� �Լ� StopCoroutine
                StopCoroutine(delayJumpCoroutione);
                delayJumpCoroutione = null;
            }
        }
    }

    // ===========================================================================

    // �Ѿ��� 3�ʸ��� �������ִ� �Լ�
    [SerializeField] float bulletTime;
    IEnumerator BulletCreateRoutine()
    {
        while (true)
        {
            // �ش� �ڵ带 ����, �۾��� �Ͻ������� ��
            yield return new WaitForSeconds(bulletTime);
            // ()�� ����ŭ �ʰ� ������ ���� �Լ��� �����Ѵ�.
            Debug.Log("�Ѿ� ����");
        }
    }

    // ===========================================================================



    // ���� ����, ����Ű�� ������ ������ �� �����ϴ� ���
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

        // �������
        rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);

        // ������� ���� ��, ���� null�� �Ͽ� ���� ������ ��ġ�� �ʰ� ������ �����ϰ� �Ѵ�.
        delayJumpCoroutione = null;
    }

    // ===========================================================================

    IEnumerator CoroutinWait()
    {
        //  < �ڷ�ƾ ���� > : �ڷ�ƾ�� �ݺ��۾� ��, ����ó���� �����Ͽ� -> �۾��� ���� Ÿ�̹��� ������ �� �ִ�.

        yield return null;                              // �� �������� ������Ų��.
        yield return new WaitForSeconds(1f);            // n�� ��, �ð��� ������Ų��.
        // ======================================================================================================
        yield return new WaitForSecondsRealtime(1f);    // ������ n�� ��, �ð��� ������Ų��.
        yield return new WaitForFixedUpdate();          // FixedUpdate �Լ��� ����� �� ���� ������ ������Ų��.
        yield return new WaitForEndOfFrame();           // �������� ������ ������ ������Ų��.
        yield return new WaitUntil(() => true);         // ������ ������ �� �� ���� ������ ������Ų��.
    }
}
