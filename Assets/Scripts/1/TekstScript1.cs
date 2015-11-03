using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TekstScript1 : MonoBehaviour
{

    public SchetchicTsvetov SchetchicTsvetov;
    public Palatka1 Palatka1;
    public catcoon1 catcoon1;
    public LogovoPaukov LogovoPaukov;
    public dobrajaAbigailScript dobrajaAbigailScript;

    Text txt;

    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Wonderful morning!\nAll the monsters sleep\nTime to gather flowers for my sister!";
    }


    void Update()
    {
        
        if (Palatka1.VPalatke == 1)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "I dont want to sleep";
        }
        
        if (Palatka1.VPalatke == 0)
        {

            if (catcoon1.UEnota == 1)
            {
                txt = gameObject.GetComponent<Text>();
                txt.text = "Hi, catcoon!";
            }

            if (catcoon1.UEnota == 0)
            {

                if (LogovoPaukov.UPaukov == 1)
                {
                    txt = gameObject.GetComponent<Text>();
                    txt.text = "I think I will not go there";
                }


                if (LogovoPaukov.UPaukov == 0)
                {
                    txt = gameObject.GetComponent<Text>();
                    txt.text = "Wonderful morning!\nAll the monsters sleep\nTime to gather flowers for my sister!";

                    if (SchetchicTsvetov.Sobrano > 0 && SchetchicTsvetov.Sobrano < 13)
                    {
                        txt = gameObject.GetComponent<Text>();
                        txt.text = "";
                    }

                    if (SchetchicTsvetov.Sobrano == 13)
                    {
                        txt = gameObject.GetComponent<Text>();
                        txt.text = "Now we put flowers on the grave Abigail!";
                    }

                    if (SchetchicTsvetov.Sobrano == 14)
                    {
                        txt = gameObject.GetComponent<Text>();
                        txt.text = "";
                    }

                    if (dobrajaAbigailScript.UAbigail == 1)
                    {
                        txt = gameObject.GetComponent<Text>();
                        txt.text = "Thanks!";
                    }
                }
            }



        }
    }
}

