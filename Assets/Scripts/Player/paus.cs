using UnityEngine;
using System.Collections;

public class paus : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком
    public Transform _playerTransform;
    public bool paused=false;

    private void OnMouseDown()
    {
        if (paused == false)
        {
            Time.timeScale = 0;
            paused = true;
        }
         else
        {
            Time.timeScale = 1;
            paused = false;
        }
    }

    private void Start()
    {
        //связь с игроком
        transform.position = new Vector3(_playerTransform.position.x + 5, _playerTransform.position.y +4, -5);
    }

    private void Update()
    {
        transform.position = new Vector3(_playerTransform.position.x + 5, _playerTransform.position.y + 4, -5);




    }
}
