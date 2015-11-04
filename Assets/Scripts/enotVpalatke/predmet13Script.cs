using UnityEngine;
using System.Collections;

public class predmet13Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;
    private void OnMouseDown()
    {
        if (enotVpalatke.predmet13enot == 1)
        {
            enotVpalatke.predmet13enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
