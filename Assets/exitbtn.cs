using UnityEngine;
using System.Collections;

public class exitbtn : MonoBehaviour {

    private void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("vihod"); 
    }
}
