using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCamera : MonoBehaviour
{
    // 플레이어를 추적할 수 있는 소스코드 작성
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;

    private void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(transform.position);
    }
}
