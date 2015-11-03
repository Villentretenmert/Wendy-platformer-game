using UnityEngine;
using System.Collections;

public class button4Script : MonoBehaviour {

    //-----------------------------------------------------------
    //переход на следующий уровень
    public PerehodNaUroven PerehodNaUroven;

    private void OnMouseDown()
    {
        if (PerehodNaUroven.MaxVozmUroven > 3)
            Application.LoadLevel("4Night");
    }

    private void OnMouseEnter()
    {
        if (PerehodNaUroven.MaxVozmUroven > 3)
        {
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/button/level4y");
        }
        else
        {
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>("menu/button/level4n");
        }


    }

    private void OnMouseExit()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/button/level4");
    }
}