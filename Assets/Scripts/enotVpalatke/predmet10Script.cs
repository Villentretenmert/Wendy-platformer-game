using UnityEngine;
using System.Collections;

public class predmet10Script : MonoBehaviour {

    public enotVpalatke enotVpalatke;

    private void OnMouseDown()
    {
        if (enotVpalatke.predmet10enot == 1)
        {
            enotVpalatke.EnotLife += 1;
        }
    }
}
