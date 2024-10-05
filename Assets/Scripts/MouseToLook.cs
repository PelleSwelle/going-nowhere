using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseToLook : MonoBehaviour
{
    //Virker overhovedet ikke endnu.
    public float yRotation;
    public float xRotation;
    public float LookSensitivity = 1;
    void Update()
    {
        yRotation += Input.GetAxis("Mouse X") * LookSensitivity;
        xRotation += Input.GetAxis("Mouse Y") * LookSensitivity;

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
    }
}
