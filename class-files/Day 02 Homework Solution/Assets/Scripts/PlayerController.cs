using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float turnSpeed = 45f;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * speed * verticalInput * Time.deltaTime);
        if (verticalInput != 0)
        {
            transform.Rotate(transform.up * turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}
