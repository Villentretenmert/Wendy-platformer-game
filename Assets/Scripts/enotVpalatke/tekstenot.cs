using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tekstenot : MonoBehaviour
{

    public enotVpalatke enotVpalatke;
    public enot enot;
    
    Text txt;

    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Catcoon is in my tent!\nNeed to kick him out!";
    }


    void Update()
    {

        if (enot.vidimiEnot == 0)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "";
        }

        if (enotVpalatke.konez ==1)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "Catcoon escaped!";
        }

        

    }
}