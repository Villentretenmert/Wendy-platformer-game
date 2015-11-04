using UnityEngine;
using System.Collections;

public class predmet12Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;
    private void OnMouseDown()
    {
        if (enotVpalatke.predmet12enot == 1)
        {
            enotVpalatke.predmet12enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
