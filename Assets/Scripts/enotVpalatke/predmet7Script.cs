﻿using UnityEngine;
using System.Collections;

public class predmet7Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;
    public AudioClip enotSound;
    private void OnMouseDown()
    {
        if (enotVpalatke.predmet7enot == 1)
        {
            enotVpalatke.EnotLife += 1;
            GetComponent<AudioSource>().PlayOneShot(enotSound);
        }
    }
}
