using UnityEngine;
using System.Collections;

public class predmet4Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;

    private void OnMouseDown()
    {
        if (enotVpalatke.predmet4enot == 1)
        {
            enotVpalatke.predmet4enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
