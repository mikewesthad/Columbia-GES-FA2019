using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulatingTransform : MonoBehaviour
{
    [SerializeField] private float translationSpeed = 2f;
    [SerializeField] private float rotationSpeed = 180f;

    void Start()
    {
        //transform.Translate(0, 0, 10);
        //transform.Rotate(0, 45, 0);
    }

    void Update()
    {
        transform.Translate(0, 0, translationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
