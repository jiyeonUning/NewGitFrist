using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTester : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;

    private void Start()
    {
        // < 비트 표현 >
        //   00000000 00000000 00000000 0000 0001
        // = 레이어 선택을 가장 첫번째 위치, 즉 0의 위치에 있는 레이어를 선택하게 된다.
        layerMask = 1 << 0;

        //   즉, 레이어마스크의 값을 1 << n 를 하게 된다면
        // = n번째 자리수만 체크해줄 수 있다.

        //==============================================================================

        // < 비트 연산자 >
        //  | (or) : 이진법의 동일한 자리가 하나만 1이어도 -> 1로 치환한다.
        //  &(and) : 이진법의 동일한 자리가 둘 다 1이라면 -> 1로 치환한다.
        //  ~(not) : 0과 1을 반전시킨다.

        bool left = true;
        bool right = false;
    }
}
