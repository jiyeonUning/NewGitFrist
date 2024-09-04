using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // ~ 싱글톤패턴 활용 예시 ~
            // 변수명 Instance를 불러와, 게임매니저에서 구현한 기능을 사용해줄 수 있다.
            GameManager.Instance.score++;
        }
    }
}
