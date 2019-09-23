using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] float shootForce = 10f;
    [SerializeField] float shotsPerSecond = 5;
    bool canShoot = true;

    void Update()
    {
        if (canShoot && Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            Rigidbody rb = ball.GetComponent<Rigidbody>();

            // A quaternion multiplied by a Vector applies that rotation to the Vector.
            Vector3 direction = Quaternion.Euler(0, 0, 15) * transform.forward;

            rb.AddForce(direction * shootForce, ForceMode.Impulse);
            canShoot = false;

            // 1 / (Shots / per second) = # of seconds between shots
            // Invoke allows us to schedule a method to run in the future.
            Invoke("EnableShooting", 1 / shotsPerSecond);
        }
    }

    void EnableShooting()
    {
        canShoot = true;
    }
}
