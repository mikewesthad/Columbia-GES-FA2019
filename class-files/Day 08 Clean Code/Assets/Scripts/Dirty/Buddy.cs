using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buddy : MonoBehaviour
{
    public GameObject b;
    public float TIME = 5;
    public bool Shooter_Shoot = true;

    void Start()
    {
Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(-Input.GetAxis("Mouse Y") * 0.75f + transform.eulerAngles.x, Input.GetAxis("Mouse X") * 0.75f + transform.eulerAngles.y, 0);
 
        if (Shooter_Shoot && Input.GetMouseButtonDown(0))
{
                GameObject gameObject = Instantiate(b, 
                    
                    transform.position, Quaternion.identity);
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Quaternion.Euler(0, 0, 15) * transform.forward * 20f, ForceMode.Impulse);
            Shooter_Shoot = false;
                    Invoke("Shooter", 1 / TIME);
        }
    }

    public       void Shooter()
    {
        Shooter_Shoot = true;
    }
}
