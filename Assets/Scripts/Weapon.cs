using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private AudioSource[] soundfx;
    void Start()
    {
        soundfx = GetComponents<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // shooting logic
        soundfx[0].Play();
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
