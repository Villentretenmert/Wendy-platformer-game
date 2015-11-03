using UnityEngine;
using System.Collections;

public class zlajaAbigail : MonoBehaviour {

    public int UAbigail = 0;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UAbigail = 1;


        }

    }
}
