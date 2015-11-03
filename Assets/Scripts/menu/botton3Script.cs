using UnityEngine;
using System.Collections;

public class botton3Script : MonoBehaviour {

    //-----------------------------------------------------------
    //переход на следующий уровень
    public PerehodNaUroven PerehodNaUroven;

    private void OnMouseDown()
    {
        if (PerehodNaUroven.MaxVozmUroven > 2)
            Application.LoadLevel("3Evening");
    }

    private void OnMouseEnter()
    {
        if (PerehodNaUroven.MaxVozmUroven > 2)
        {
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>("menu/button/level3y");
        }
        else
        {
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>("menu/button/level3n");
        }



    }

    private void OnMouseExit()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/button/level3");
    }
}