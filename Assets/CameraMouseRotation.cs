using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseRotation : MonoBehaviour
{
    public float sensitivity = 10f;
    public float minimumY = -60F;
    public float maximumY = 60F;

    float rotationX;
    float rotationY;
    // Update is called once per frame
    void Update()
    {
        var c = Camera.main.transform;
        //c.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        //c.Rotate(-Input.GetAxis("Mouse Y") * sensitivity, 0, 0);


        rotationX +=  Input.GetAxis("Mouse X") * sensitivity;
        rotationY +=  Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        c.eulerAngles = new Vector3( -rotationY, rotationX , 0);

        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
    }
}
