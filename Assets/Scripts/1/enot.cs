using UnityEngine;
using System.Collections;

public class enot : MonoBehaviour {

    public GameObject Enot;
    public int vidimiEnot = 1;

   

    private void OnMouseDown()
    {
        if (vidimiEnot == 1)
        {
            Enot.SetActive(false);
            vidimiEnot = 0;
        }

       
       
    }


}
