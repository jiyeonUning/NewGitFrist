using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTester : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;

    private void Start()
    {
        // < ��Ʈ ǥ�� >
        //   00000000 00000000 00000000 0000 0001
        // = ���̾� ������ ���� ù��° ��ġ, �� 0�� ��ġ�� �ִ� ���̾ �����ϰ� �ȴ�.
        layerMask = 1 << 0;

        //   ��, ���̾��ũ�� ���� 1 << n �� �ϰ� �ȴٸ�
        // = n��° �ڸ����� üũ���� �� �ִ�.

        //==============================================================================

        // < ��Ʈ ������ >
        //  | (or) : �������� ������ �ڸ��� �ϳ��� 1�̾ -> 1�� ġȯ�Ѵ�.
        //  &(and) : �������� ������ �ڸ��� �� �� 1�̶�� -> 1�� ġȯ�Ѵ�.
        //  ~(not) : 0�� 1�� ������Ų��.

        bool left = true;
        bool right = false;
    }
}
