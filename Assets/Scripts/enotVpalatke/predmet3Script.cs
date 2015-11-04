using UnityEngine;
using System.Collections;

public class predmet3Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;

    private void OnMouseDown()
    {
        if (enotVpalatke.predmet3enot == 1)
        {
            enotVpalatke.predmet3enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
