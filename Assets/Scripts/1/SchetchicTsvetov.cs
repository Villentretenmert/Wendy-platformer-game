using UnityEngine;
using System.Collections;

public class SchetchicTsvetov : MonoBehaviour {

    public int maxTsvetov = 13;
    public int Sobrano = 0;

    //--------------------------------------------------------------------
    //мелодия на каждый сбор цветка

    public int tsvetovBilo = 0;
    public int tsvetovStalo = 0;

    public AudioClip floverSound;

    private void Start()
    {
        tsvetovBilo = 0;
    }

    private void Update()
    {
        tsvetovStalo = Sobrano;
        if (tsvetovStalo != tsvetovBilo && Sobrano < 14)
            GetComponent<AudioSource>().PlayOneShot(floverSound);
        tsvetovBilo = Sobrano;
    }
}
