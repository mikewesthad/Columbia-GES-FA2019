using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float horizontalMouseSensitivity = 0.5f;
    [SerializeField] private float verticalMouseSensitivity = 0.5f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float deltaMouseHorizontal = Input.GetAxis("Mouse X") * horizontalMouseSensitivity;
        float deltaMouseVertical = Input.GetAxis("Mouse Y") * verticalMouseSensitivity;
        float newCameraRotY = transform.eulerAngles.y + deltaMouseHorizontal;
        float newCameraRotX = transform.eulerAngles.x - deltaMouseVertical;

        transform.eulerAngles = new Vector3(newCameraRotX, newCameraRotY, 0);
    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
