using UnityEngine;
using System.Collections;

public class prigalkiDlaPauka : MonoBehaviour {

    public bool trigger = false;
    //обращ к скрипту с глобальной перем
    public imapauka ima;
    public Transform _playerTransform;
  

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "pauk" && _playerTransform.position.y > GetComponent<Transform>().position.y + 2)
        {
            //воронномер=получаем имя ворона
            ima.imaPauka = other.name;
            trigger = true;
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
