using UnityEngine;
using System.Collections;

public class diedflover : MonoBehaviour {


    public SchetchikHeals heals;
    public static int videlaRaz = 0;
    public static int UTsvetka = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
            if (heals.Heals > 0)
            {
                heals.Heals -= 1;
                if (videlaRaz == 0)
                {
                    UTsvetka = 1;
                    videlaRaz += 1;
                }
            }

        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            UTsvetka = 0;

    }
}
