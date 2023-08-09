using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float speed = 10f;

  
    
      

    void Update()
    {
        /* Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
         Vector3 hizeklentisi = playerInput * Time.deltaTime * speed;
         transform.position = hizeklentisi;*/
        float xHorizontal = Input.GetAxis("Horizontal");
        float zVertical = Input.GetAxis("Vertical");
        Vector3 moveSystem = new Vector3(xHorizontal, 0.0f, zVertical);
        transform.position += moveSystem * speed * Time.deltaTime;



    }
}
