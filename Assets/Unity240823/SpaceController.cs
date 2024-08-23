using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    void Update()
    {
    }

    private void Write()
    {
        // < 방향의 종류 >
        // 글로벌 스페이스 = 동서남북
        // 로컬 스페이스   = 상하좌우 (본인기준)

        // 세상을 기준(글로벌 스페이스)으로 이동 = Space.World / 자신을 기준(로컬 스페이스)으로 이동 = Space.Self
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        // 세상을 기준(글로벌 스페이스)으로 회전 = Space.World / 자신을 기준(로컬 스페이스)으로 회전 = Space.Self
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }
}
