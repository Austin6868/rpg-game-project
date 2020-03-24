using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//this is set to LMB
		{
            Shoot();
		}
    }
    void Shoot()//the method that instantiate the bullet at the desired firepoint of the gun
	{
        GameObject bullet = Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce , ForceMode2D.Impulse);
	}
}
