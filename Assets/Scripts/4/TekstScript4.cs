using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TekstScript4 : MonoBehaviour
{

    public ShetchicPaukov ShetchicPaukov;

    public Palatka1 Palatka1;
    public LogovoPaukov LogovoPaukov;
    private float Timer1 = 2;
    private float TimerDown;
    public SchetchikHeals SchetchikHeals;
    Text txt;

    void Start()
    {
        TimerDown = Timer1;
        txt = gameObject.GetComponent<Text>();
        txt.text = "Night of nightmares!\nLet Abigail be between me and  monsters";
    }


    void Update()
    {
        if (SchetchikHeals.Heals == 0 && ShetchicPaukov.SobranoPaukov < 7)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "I have little time";
        }

        if (SchetchikHeals.Heals == 0 && ShetchicPaukov.SobranoPaukov == 7)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "We won!";
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

                    if (SchetchikHeals.Ugriba == 1)
                    {
                        txt = gameObject.GetComponent<Text>();
                        txt.text = "Mushrooms for bravery";
                    }


                    if (SchetchikHeals.Ugriba == 0)
                    {

                        txt = gameObject.GetComponent<Text>();
                        txt.text = "Night of nightmares!\nLet Abigail be between me and  monsters";

                        if (ShetchicPaukov.SobranoPaukov > 0 && ShetchicPaukov.SobranoPaukov < 7)
                        {
                            txt = gameObject.GetComponent<Text>();
                            txt.text = "";
                        }

                        if (ShetchicPaukov.SobranoPaukov == 7)
                        {
                            txt = gameObject.GetComponent<Text>();
                            txt.text = "We won!";
                        }



                    }
                }
            }
        }
    }
}
