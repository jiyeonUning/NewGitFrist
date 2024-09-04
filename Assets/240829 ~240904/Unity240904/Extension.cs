using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class Extension
{
    // ���̾ üũ��Ű�� ���
    public static void Check(this ref LayerMask layerMask, int layer)
    {
        layerMask |= 1 << layer;
    }

    // ���̾ üũ ���� ��Ű�� ���
    public static void UnCheck(this ref LayerMask layerMask, int layer)
    {
        layerMask &= ~(1 << layer);
    }

    // ���̾��� üũ�� Ȯ���ϴ� ���
    public static bool Contain(this LayerMask layerMask, int layer)
    {
        return (layerMask & (1 << layer)) != 0;
    }
}
