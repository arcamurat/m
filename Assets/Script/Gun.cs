using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2D : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    void Update()
    {
        // Update mouse position every frame
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Calculate direction towards mouse position
            Vector2 direction = (mousePosition - (Vector2)bulletSpawnPoint.position).normalized;

            // Instantiate bullet and set velocity
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        }
    }
}
