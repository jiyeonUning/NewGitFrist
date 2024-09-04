using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class Extension
{
    // 확장메서드로 기능을 추가 (레이어마스크 사용 시, 해당 함수를 추가함)

    // 레이어를 체크시키는 기능
    public static void Check(this ref LayerMask layerMask, int layer)
    {
        layerMask |= 1 << layer;
    }

    // 레이어를 체크 해제 시키는 기능 
    public static void UnCheck(this ref LayerMask layerMask, int layer)
    {
        layerMask &= ~(1 << layer);
    }

    // 레이어의 체크를 확인하는 기능
    public static bool Contain(this LayerMask layerMask, int layer)
    {
        return (layerMask & (1 << layer)) != 0;
    }
}
