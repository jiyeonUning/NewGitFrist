using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    // 타겟에 총알이 맞았을 때, 해당 타겟을 없애는 함수
    public void TakeHit()
    {
        Destroy(gameObject);
        // 해당 함수가 아니더라도, 체력을 줄인다거나 하는 방식으로 다양한 기능을 구현할 수 있다.
    }
}
