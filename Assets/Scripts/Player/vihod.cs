using UnityEngine;
using System.Collections;

public class vihod : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком
    public Transform _playerTransform;

    private void OnMouseDown()
    {
        Application.LoadLevel("GameMenu");
    }

    private void Start()
    {
        //связь с игроком
        transform.position = new Vector3(_playerTransform.position.x + 5, _playerTransform.position.y + 5, -5);
    }

    private void Update()
    {
        transform.position = new Vector3(_playerTransform.position.x + 5, _playerTransform.position.y + 5, -5);


       

    }
}
