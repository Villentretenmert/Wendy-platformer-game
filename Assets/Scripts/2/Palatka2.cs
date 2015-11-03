using UnityEngine;
using System.Collections;

public class Palatka2 : MonoBehaviour {


    public static int SobranoDichi = 0;
    public SchetchicEda SchetchicEda;
    public static int videlaRaz = 0;
    public int VPalatke = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
            if (videlaRaz == 0)
            {
                SobranoDichi = SchetchicEda.SobranoEda;
                Application.LoadLevel("enotVpalatke");
                videlaRaz += 1;

            }
            else
            {
                VPalatke = 1;
            }


        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" && videlaRaz > 0)
            VPalatke = 0;


    }
}