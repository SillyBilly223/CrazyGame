using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyGun : MonoBehaviour
{

    public Transform bulletSpawnPoint;
    public Transform bulletPrefab;
    public float bulletSpeed = 10;

    void Update()
    {
        GunShot();
    }

    void GunShot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
        }
    }
}
