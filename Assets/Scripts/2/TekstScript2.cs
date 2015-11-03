using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TekstScript2 : MonoBehaviour
{

    public SchetchicEda SchetchicEda;
    public Palatka2 Palatka2;

    public LogovoPaukov LogovoPaukov;
    public Teftelli tefteli;
    public SchetchikHeals SchetchikHeals;

    Text txt;

    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Sunny noon!\nI'm hungry\nLet's catch prey for lunch!";
    }


    void Update()
    {
        if (SchetchikHeals.Heals == 0 && tefteli.UTefteli == 0)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "I have little time";
        }
        if (SchetchikHeals.Heals == 0 && tefteli.UTefteli == 1)
        {
            txt = gameObject.GetComponent<Text>();
            txt.text = "Looks yummy!";
        }
        if (SchetchikHeals.Heals > 0)
        {

            if (Palatka2.VPalatke == 1)
            {
                txt = gameObject.GetComponent<Text>();
                txt.text = "I dont want to sleep";
            }

            if (Palatka2.VPalatke == 0)
            {



                if (LogovoPaukov.UPaukov == 1)
                {
                    txt = gameObject.GetComponent<Text>();
                    txt.text = "I think I will not go there";
                }


                if (LogovoPaukov.UPaukov == 0)
                {

                    if (tefteli.UTefteli == 1)
                    {
                        txt = gameObject.GetComponent<Text>();
                        txt.text = "Looks yummy!";
                    }
                    if (tefteli.UTefteli == 0)
                    {

                        txt = gameObject.GetComponent<Text>();
                        txt.text = "Sunny noon!\nI'm hungry\nLet's catch prey for lunch!";

                        if (SchetchicEda.SobranoEda > 0 && SchetchicEda.SobranoEda < 6)
                        {
                            txt = gameObject.GetComponent<Text>();
                            txt.text = "";
                        }

                        if (SchetchicEda.SobranoEda == 6)
                        {
                            txt = gameObject.GetComponent<Text>();
                            txt.text = "Now we put prey in the pot!";
                        }

                        if (SchetchicEda.SobranoEda == 7)
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