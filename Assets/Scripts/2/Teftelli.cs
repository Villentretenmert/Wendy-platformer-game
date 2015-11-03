using UnityEngine;
using System.Collections;

public class Teftelli : MonoBehaviour {

    public int UTefteli = 0;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UTefteli = 1;


        }

    }
}
