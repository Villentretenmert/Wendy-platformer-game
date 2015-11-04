using UnityEngine;
using System.Collections;

public class predmet5Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;
    private void OnMouseDown()
    {
        if (enotVpalatke.predmet5enot == 1)
        {
            enotVpalatke.predmet5enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
