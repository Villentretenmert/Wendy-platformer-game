using UnityEngine;
using System.Collections;

public class poluprigalkiDlaPauka : MonoBehaviour {

    public bool trigger = false;
    //обращ к скрипту с глобальной перем
    public imapauka ima;
    //----------------------------------------------------------------------------
    //связь с игроком и пауком
    public Transform _playerTransform;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "pauk")
        {
            if (_playerTransform.position.y < GetComponent<Transform>().position.y)
            {
                ima.imaPauka = "";
                trigger = false;
            }
            else
            {
                //воронномер=получаем имя ворона
                ima.imaPauka = other.name;
                trigger = true;
            }

        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "pauk")
        {
            ima.imaPauka = "";
            trigger = false;
        }

    }
}
