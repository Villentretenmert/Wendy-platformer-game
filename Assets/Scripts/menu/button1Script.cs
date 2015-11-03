using UnityEngine;
using System.Collections;

public class button1Script : MonoBehaviour {

    

    private void OnMouseDown()
    {
        Application.LoadLevel("1Morning");
    }

    private void OnMouseEnter()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/button/level1y");

    }

    private void OnMouseExit()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/button/level1");
    }
}
