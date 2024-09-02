using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionTester : MonoBehaviour
{
    // 리지드바디를 통해 충돌을 감지하는 함수들
    //========================================================================================
    //                                    ~ 기본 개념 ~

    // Conllision = 충돌과 관련된 정보값을 지닌다.

    // 충돌되었을 때(=충돌을 시작했을 때) 실행되는 함수 OnCollisionEnter
    private void OnCollisionEnterTest(Collision collision)
    {
        Debug.Log($"부딫힌 충돌체 : {collision.gameObject.name}");
        
        // 응용 if문 : 부딫힌 충돌체의 이름이 " "의 이름과 같을 때,
        // 특정 코드(ex:데미지입힘, 튕겨내기 등...)를 실행시킬 수 있다.
        if (collision.gameObject.name == "Tank Orgin")
        {
            Debug.Log($"플레이어어가 부딫힐 때, 총알은 플레이어에게 데미지를 준다.");
            // 플레이어와 부딫혔을 때, 사용의 의의를 다한 총알은 사라진다.
            Destroy(gameObject);
        }
    }

    // 충돌하는 중일 때(=충돌체와 서로 계속 맞닿아있을 때) 실행되는 함수 OnCollisionStay
    private void OnCollisionStayTest(Collision collision)
    {
        Debug.Log($"부딫히고 있는 충돌체 : {collision.gameObject.name}");
    }

    // 충돌이 끝났을 때(=충돌체와 떨어졌을 때) 실행되는 함수 OnCollisionExit
    private void OnCollisionExitTest(Collision collision)
    {
        Debug.Log($"부딫힘이 끝난 충돌체 : {collision.gameObject.name}");
    }

    //========================================================================================
}
