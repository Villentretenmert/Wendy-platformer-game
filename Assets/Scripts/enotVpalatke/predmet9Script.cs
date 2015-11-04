using UnityEngine;
using System.Collections;

public class predmet9Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;

    private void OnMouseDown()
    {
        if (enotVpalatke.predmet9enot == 1)
        {
            enotVpalatke.predmet9enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
