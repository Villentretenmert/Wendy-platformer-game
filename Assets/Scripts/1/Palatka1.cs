using UnityEngine;
using System.Collections;

public class Palatka1 : MonoBehaviour {

    public int VPalatke = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            VPalatke =1;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            VPalatke = 0;
            
        
    }
}
