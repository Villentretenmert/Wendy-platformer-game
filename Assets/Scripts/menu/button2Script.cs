using UnityEngine;
using System.Collections;

public class button2Script : MonoBehaviour {

    //-----------------------------------------------------------
    //переход на следующий уровень
    public PerehodNaUroven PerehodNaUroven;

    private void OnMouseDown()
    {
        if(PerehodNaUroven.MaxVozmUroven > 1)
            Application.LoadLevel("2Noon");
    }

    private void OnMouseEnter()
    {
        if (PerehodNaUroven.MaxVozmUroven > 1)
        {
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>("menu/button/level2y");
        }
        else
        {
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>("menu/button/level2n");
        }
        
       

    }

    private void OnMouseExit()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/button/level2");
    }
}
