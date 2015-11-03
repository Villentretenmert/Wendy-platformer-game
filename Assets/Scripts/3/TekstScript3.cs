using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TekstScript3 : MonoBehaviour
{

    public SchetchicVoron SchetchicVoron;
    public Palatka1 Palatka1;
    public LogovoPaukov LogovoPaukov;
    public diedflover diedflover;
    public zlajaAbigail zlajaAbigail;
    public SchetchikHeals SchetchikHeals;

    Text txt;

    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Evening in full swing\nI need helper\nand raven's blood to invoke him";
    }


    void Update()
    {
        if (SchetchikHeals.Heals == 0 && zlajaAbigail.UAbigail == 0)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "I have little time";
        }

        if (SchetchikHeals.Heals == 0 && zlajaAbigail.UAbigail == 1)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "Night is coming";
        }

        if (SchetchikHeals.Heals > 0)
        {
            if (Palatka1.VPalatke == 1)
            {
                txt = gameObject.GetComponent<Text>();
                txt.text = "I dont want to sleep";
            }

            if (Palatka1.VPalatke == 0)
            {



                if (LogovoPaukov.UPaukov == 1)
                {
                    txt = gameObject.GetComponent<Text>();
                    txt.text = "I think I will not go there";
                }


                if (LogovoPaukov.UPaukov == 0)
                {

                    if (diedflover.UTsvetka == 1)
                    {
                        txt = gameObject.GetComponent<Text>();
                        txt.text = "Disgusting smell!";
                    }
                    if (diedflover.UTsvetka == 0)
                    {
                        if (zlajaAbigail.UAbigail == 1)
                        {
                            txt = gameObject.GetComponent<Text>();
                            txt.text = "Night is coming";
                        }

                        if (zlajaAbigail.UAbigail == 0)
                        {
                            txt = gameObject.GetComponent<Text>();
                            txt.text = "Evening in full swing\nI need helper\nand raven's blood to invoke him";

                            if (SchetchicVoron.SobranoVoron > 0 && SchetchicVoron.SobranoVoron < 3)
                            {
                                txt = gameObject.GetComponent<Text>();
                                txt.text = "";
                            }

                            if (SchetchicVoron.SobranoVoron == 3)
                            {
                                txt = gameObject.GetComponent<Text>();
                                txt.text = "Invoke the Abigail\nDo you remember where the grave is? ";
                            }

                            if (SchetchicVoron.SobranoVoron == 4)
                            {
                                txt = gameObject.GetComponent<Text>();
                                txt.text = "";
                            }

                        }

                    }
                }
            }
        }
    }
}
