using UnityEngine;
using System.Collections;

public class LogovoPaukov : MonoBehaviour {

    public int UPaukov = 0;
    public AudioClip logovoPaukovSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UPaukov = 1;
            GetComponent<AudioSource>().PlayOneShot(logovoPaukovSound);

        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            UPaukov = 0;


    }
}
