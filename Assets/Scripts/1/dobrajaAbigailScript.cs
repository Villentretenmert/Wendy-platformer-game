using UnityEngine;
using System.Collections;

public class dobrajaAbigailScript : MonoBehaviour {

    public int UAbigail = 0;
    public AudioClip dobrajaAbigailvSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UAbigail = 1;
            GetComponent<AudioSource>().PlayOneShot(dobrajaAbigailvSound);

        }

    }

    
}