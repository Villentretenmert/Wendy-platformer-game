using UnityEngine;
using System.Collections;

public class PredmetImage : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком
    public Transform _playerTransform;
    

    private void Start()
    {
        //связь с игроком
        transform.position = new Vector3(_playerTransform.position.x - 5, _playerTransform.position.y + 3, -5);
    }

    private void Update()
    {
        transform.position = new Vector3(_playerTransform.position.x - 5, _playerTransform.position.y + 3, -5);


           }
    }
