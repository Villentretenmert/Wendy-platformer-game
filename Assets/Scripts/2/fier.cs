using UnityEngine;
using System.Collections;

public class fier : MonoBehaviour {

    
    public AudioClip tefteliSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            GetComponent<AudioSource>().PlayOneShot(tefteliSound);

        }

    }



}