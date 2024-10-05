using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //objects
    public GameObject Car;
    public new Camera camera;
    public Transform ThirdPersonCamera;
    public Animator cameraAnim;
    public bool IsInCar = true;
    //Alt positioning forgår ud fra target(car)
    public Transform target;


    void OnValidate()
    {
        Car = GameObject.FindGameObjectWithTag("Car");
        target = Car.transform; 
    }
    //Camera transform;
    public float distanceToCar = 2.0f;
    public Vector3 camPos;
    public float camHeight = 4;

    public bool toggleViewButton;


    void Start()
    {
       // cameraAnim.SetBool("IsInside", true);
    }

    void Update()
    {
        camPos.z = target.transform.position.z - distanceToCar;
        camPos.x = target.transform.position.x;
        camPos.y = target.transform.position.y + camHeight;

        camera.transform.position = camPos;
        transform.LookAt(target);
        //move camera to distance/height/rot

        toggleViewButton = Input.GetKeyDown(KeyCode.E);
        if (toggleViewButton)
        {
            if (IsInCar)
            {
                //cameraAnim.Play("CameraMove");
                //cameraAnim.SetBool("HasMovedOut", true);
                IsInCar = false;
            }
            else
            {
                //cameraAnim.Play("CameraMoveInside");
                //cameraAnim.SetBool("HasMovedIn", true);
                IsInCar = true;
            }
        }
    }
}
