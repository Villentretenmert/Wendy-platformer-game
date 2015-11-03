using UnityEngine;
using System.Collections;

public class SchetchicEda : MonoBehaviour {

    public int maxEda = 6;
    public  int SobranoEda = 0;

    //--------------------------------------------------------------------
    //мелодия на каждый сбор дичи

    public int EdaBilo = 0;
    public int EdaStalo = 0;

    public AudioClip dichSound;

    private void Start()
    {
        EdaBilo = 0;
        SobranoEda = Palatka2.SobranoDichi;
    }

    private void Update()
    {
        EdaStalo = SobranoEda;
        if (EdaStalo != EdaBilo && SobranoEda < 7)
            GetComponent<AudioSource>().PlayOneShot(dichSound);
        EdaBilo = SobranoEda;
    }
}
