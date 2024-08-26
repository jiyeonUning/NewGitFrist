using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTwo : MonoBehaviour
{
    [SerializeField] ObjectPool bulletPool;
    [SerializeField] Transform muzzlePoint;

    [Range(1, 10)]
    [SerializeField] float bulletSpeed;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { Fire(); }
    }

    public void Fire()
    {
        PooledObject instance = bulletPool.GetPool(muzzlePoint.position, muzzlePoint.rotation);
        Bullet bullet = instance.GetComponent<Bullet>();
        bullet.SetSpeed(bulletSpeed);
    }
}
