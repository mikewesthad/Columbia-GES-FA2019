using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMover : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    Vector3 target;    

    void Start()
    {
        SetNewTarget();
    }

    void Update()
    {
        // Take a small step from the current position to the target position each frame.
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position == target)
        {
            SetNewTarget();
        }
    }

    void SetNewTarget()
    {
        // Copy the post's current position.
        Vector3 pos = transform.position;

        // We figured out these values from moving the basketball post around in the editor:
        pos.z = Random.Range(-2.5f, 2.5f);
        target = pos;
    }
}
