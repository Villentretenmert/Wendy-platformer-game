using UnityEngine;
using System.Collections;

public class SchetchicVoron : MonoBehaviour {

    public int maxVoron = 3;
    public int SobranoVoron = 0;

    //--------------------------------------------------------------------
    //мелодия на каждый сбор ворон

    public int VoronBilo = 0;
    public int VoronStalo = 0;

    public AudioClip VoronSound;

    private void Start()
    {
        VoronBilo = 0;
    }

    private void Update()
    {
        VoronStalo = SobranoVoron;
        if (VoronStalo != VoronBilo && SobranoVoron < 4)
            GetComponent<AudioSource>().PlayOneShot(VoronSound);
        VoronBilo = SobranoVoron;
    }
}
