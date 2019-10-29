using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // No magic numbers and no public fields to make something visible in the inspector.
    [SerializeField] GameObject ballPrefab;
    [SerializeField] float shootForce = 10f;
    [SerializeField] float shotsPerSecond = 5;
    [SerializeField] float upwardShootForceTilt = 15;
    bool canShoot = true;

    void Update()
    {
        if (canShoot && Input.GetMouseButtonDown(0))
        {
            // Use descriptive variable names.
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            Vector3 shootDirection = Quaternion.Euler(0, 0, upwardShootForceTilt) * transform.forward;
            ballRigidbody.AddForce(shootDirection * shootForce, ForceMode.Impulse);
            canShoot = false;
            Invoke("EnableShooting", 1 / shotsPerSecond);
        }
    }

    void EnableShooting()
    {
        canShoot = true;
    }
}
