using UnityEngine;
using System.Collections;

public class catcoon1 : MonoBehaviour {

    public int UEnota = 0;
    public int videlaRaz = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && videlaRaz == 0)
        {
            UEnota = 1;
            videlaRaz += 1;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            UEnota = 0;
          
    }
}