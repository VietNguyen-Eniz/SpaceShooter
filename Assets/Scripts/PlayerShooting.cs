using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Shoot when click left mouse button 
//public class PlayerShooting : MonoBehaviour
//{
//    public GameObject bulletPrefab;

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            Instantiate(bulletPrefab, transform.position,
//            transform.rotation);
//        }
//    }
//}

//This is Auto
public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    private float lastBulletTime;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime >
            shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }
    private void ShootBullet()
    {
        Instantiate(bulletPrefabs, transform.position, transform.rotation);
    }
}