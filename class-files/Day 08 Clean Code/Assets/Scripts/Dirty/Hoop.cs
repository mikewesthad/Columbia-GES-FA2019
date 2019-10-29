using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop : MonoBehaviour
{
    public Vector3 target;

    void Start()
    {
        SetNewTarget();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 2f * Time.deltaTime);

        Debug.Log(transform.position);
        Debug.Log(Time.deltaTime);

        Vector3 currentPosition = transform.position;

        //if (transform.position == Vector3.zero)
        //{
        //}

        if (transform.position == target)
        {
            SetNewTarget();
        }
    }

    void SetNewTarget()
    {
        Vector3 the_position = transform.position;
        the_position.z = Random.Range(-2.5f, 2.5f);
        target = the_position;
    }
}
