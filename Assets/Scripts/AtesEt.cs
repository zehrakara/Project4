using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEt : MonoBehaviour
{
    RaycastHit hit;
   
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
            }

        }
    }
}
