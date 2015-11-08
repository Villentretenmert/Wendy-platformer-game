using UnityEngine;
using System.Collections;

public class predmet14Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;

    private void OnMouseDown()
    {
        if (enotVpalatke.predmet14enot == 1)
        {
            enotVpalatke.predmet14enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
