using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket2 : MonoBehaviour
{
    public float speed = 15f;
    
    
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        Vector3 hizeklentisi = playerInput * Time.deltaTime * speed;
        transform.Translate(hizeklentisi);
    }
}
