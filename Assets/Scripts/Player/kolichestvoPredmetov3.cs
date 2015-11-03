using UnityEngine;
using System.Collections;

public class kolichestvoPredmetov3 : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком

    public SchetchicVoron SchetchicVoron;

    private void Start()
    {
    }

    private void Update()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();

        if (SchetchicVoron.SobranoVoron == 0)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/0");

        if (SchetchicVoron.SobranoVoron == 1)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/1");

        if (SchetchicVoron.SobranoVoron == 2)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/2");

        if (SchetchicVoron.SobranoVoron == 3)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/3");





    }
}
