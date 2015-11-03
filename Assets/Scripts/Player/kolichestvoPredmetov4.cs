using UnityEngine;
using System.Collections;

public class kolichestvoPredmetov4 : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком

    public ShetchicPaukov ShetchicPaukov;

    private void Start()
    {
    }

    private void Update()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();

        if (ShetchicPaukov.SobranoPaukov == 0)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/0");

        if (ShetchicPaukov.SobranoPaukov == 1)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/1");

        if (ShetchicPaukov.SobranoPaukov == 2)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/2");

        if (ShetchicPaukov.SobranoPaukov == 3)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/3");

        if (ShetchicPaukov.SobranoPaukov == 4)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/4");

        if (ShetchicPaukov.SobranoPaukov == 5)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/5");

        if (ShetchicPaukov.SobranoPaukov == 6)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/6");

        if (ShetchicPaukov.SobranoPaukov == 7)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/7");


    }
}
