using UnityEngine;
using System.Collections;

public class exitbtn : MonoBehaviour {

    private void OnMouseDown()
    {
        Application.Quit();
        
    }

    private void OnMouseEnter()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/exity");

    }

    private void OnMouseExit()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.sprite = Resources.Load<Sprite>("menu/exit");
    }
}
