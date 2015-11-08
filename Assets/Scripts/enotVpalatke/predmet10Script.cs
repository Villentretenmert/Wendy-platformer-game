using UnityEngine;
using System.Collections;

public class predmet10Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;
    private void OnMouseDown()
    {
        if (enotVpalatke.predmet10enot == 1)
        {
            enotVpalatke.predmet10enot =0;
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
