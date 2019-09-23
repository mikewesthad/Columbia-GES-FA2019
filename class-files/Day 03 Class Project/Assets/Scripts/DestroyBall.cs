using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    void Start()
    {
        // Schedule destruction as soon as the ball is created, so that we don't accumulate
        // a whole bunch on top of the court.
        Destroy(gameObject, 6);
    }

    void Update()
    {
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }

}
