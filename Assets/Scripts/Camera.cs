using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensivity = 1000f;
    public GameObject oyuncu;
    internal static object main;

    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0,0);
        oyuncu.transform.Rotate(Vector3.up * mouseX);
    }
}
