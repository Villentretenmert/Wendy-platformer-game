using UnityEngine;
using System.Collections;

public class flover : MonoBehaviour
{
    
    public GameObject Tsvetok;
    public SchetchicTsvetov Sobr;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Sobr.Sobrano < Sobr.maxTsvetov)
            {
                
                Sobr.Sobrano += 1;
                Tsvetok.SetActive(false);
                
            }
            
        }
    }
}