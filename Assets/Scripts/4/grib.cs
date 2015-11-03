using UnityEngine;
using System.Collections;

public class grib : MonoBehaviour {

    public GameObject gribi;
    public SchetchikHeals SchetchikHeals;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (SchetchikHeals.Heals > 0)
            {
                

                if (SchetchikHeals.Heals < 10)
                {

                    SchetchikHeals.Heals += 1;
                    gribi.SetActive(false);



                }

            }
        }

    }

    
    }
