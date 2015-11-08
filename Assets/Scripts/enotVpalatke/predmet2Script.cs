using UnityEngine;
using System.Collections;

public class predmet2Script : MonoBehaviour {
    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;
    private void OnMouseDown()
    {
        if (enotVpalatke.predmet2enot == 1)
        {
            enotVpalatke.predmet2enot = 0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
