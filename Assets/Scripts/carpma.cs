using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSphere : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " 'a carpti");
    }
}
