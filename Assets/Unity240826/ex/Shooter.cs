using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [Range(1, 10)]
    [SerializeField] float bulletSpeed;
    [SerializeField] Transform muzzlePoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { Fire(); }
    }

    public void Fire()
    {
        GameObject instance = Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation); // 총알 프리팹 생성
        Bullet bullet = instance.GetComponent<Bullet>(); // 불릿의 컴포넌트를 가져와
        bullet.SetSpeed(bulletSpeed); // 원래 설정되어있던 불릿의 속도를 슈터에서 설정한 불릿의 속도로 변경해준다.
    }
}
