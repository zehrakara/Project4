using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxiss : MonoBehaviour
{
    private float deger, deger2;
    void Update()
    {
       deger= Input.GetAxis("Horizontal");
        deger2 = Input.GetAxis("Vertical");
        if(deger>0)
        {
            print("D veya sol tuşa bastiniz");
        }
        else if(deger==0)
        {
            print("Hic tusa basmadiniz ");
        }
        else
        {
            print("A veya sol ok tusuna bastiniz");
        }
        if (deger2 > 0)
        {
            print("W veya yukari tuşa bastiniz");
        }
        else if (deger2 == 0)
        {
            print("Hic tusa basmadiniz ");
        }
        else
        {
            print("S veya asagi ok tusuna bastiniz");
        }

    }
}
