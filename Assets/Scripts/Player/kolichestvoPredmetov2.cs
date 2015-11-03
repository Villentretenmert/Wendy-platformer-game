using UnityEngine;
using System.Collections;

public class kolichestvoPredmetov2 : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком
   
    public SchetchicEda SchetchicEda;

    private void Start()
    {
            }

    private void Update()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();

        if (SchetchicEda.SobranoEda == 0)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/0");

        if (SchetchicEda.SobranoEda == 1)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/1");

        if (SchetchicEda.SobranoEda == 2)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/2");

        if (SchetchicEda.SobranoEda == 3)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/3");

        if (SchetchicEda.SobranoEda == 4)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/4");

        if (SchetchicEda.SobranoEda == 5)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/5");

        if (SchetchicEda.SobranoEda == 6)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/6");

        

    }
}
