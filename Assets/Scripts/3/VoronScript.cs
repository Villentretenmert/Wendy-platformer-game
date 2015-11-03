using UnityEngine;
using System;
using System.Collections;

public class VoronScript : MonoBehaviour {
    //----------------------------------------------------------------------------
    //поворот персонажа
    private float tekTochkaX = 1f;
    private float proshTochkaX = 1f;

    //----------------------------------------------------------------------------
    //связь с игроком
    public Transform _playerTransform;

    public float playerX = 1f;
    public float playerY = 1f;
    public float playerDistance = 1f;

    public Rigidbody2D rb;

    public float voronSpeed = 1f;
    public SchetchikHeals heals;
    //----------------------------------------------------------------------------
    //определяем, на земле ли персонаж
    //находится ли персонаж на земле или в прыжке?
    private bool isGrounded = false;
    //ссылка на компонент Transform объекта
    //для определения соприкосновения с землей
    public Transform groundCheck;
    //радиус определения соприкосновения с землей
    private float groundRadius = 0.2f;
    //ссылка на слой, представляющий землю
    public LayerMask whatIsGround;

    //----------------------------------------------------------------------------
    //исчезновение при касании персонажа
    public GameObject voron;
    public SchetchicVoron Sobrano;

    //----------------------------------------------------------------------------
    //прыжок на триггере
    public imaVoronaScript imaVorona;
    //к глоб перем



    private void Start()
    {
        //----------------------------------------------------------------------------
        //поворот персонажа
        proshTochkaX = GetComponent<Transform>().position.x;
        //----------------------------------------------------------------------------
        //связь с игроком
        rb = GetComponent<Rigidbody2D>();
        //получу имя ворона
        
    }
             
   
    private void FixedUpdate()
    {
        //----------------------------------------------------------------------------
        //определяем, на земле ли персонаж
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (isGrounded == true)
        {

            //----------------------------------------------------------------------------
            //связь с игроком
            playerX = _playerTransform.position.x;
            playerY = _playerTransform.position.y;
            float voronX = GetComponent<Transform>().position.x;
            float voronY = GetComponent<Transform>().position.y;
            playerDistance = Mathf.Sqrt(((voronX - playerX) * (voronX - playerX)) + ((voronY - playerY) * (voronY - playerY)));

            if (imaVorona.imaVorona == name)//имя глоб перем и имя ворона
            {
                if (playerX < voronX)
                    transform.position = new Vector3(voronX + 1, voronY + 3, 0);

                if (playerX > voronX)
                    transform.position = new Vector3(voronX - 1, voronY + 3, 0);
            }

            if (playerDistance < 5 && imaVorona.imaVorona == "")
            {
                if (playerX < voronX)
                    rb.velocity = new Vector2(voronSpeed, 0);

                else
                    rb.velocity = new Vector2(-voronSpeed, 0);

            }

        }
        //----------------------------------------------------------------------------
        //исчезновение при касании персонажа
        if (playerDistance < 1 && Sobrano.SobranoVoron < Sobrano.maxVoron && heals.Heals > 0)
        {
            Sobrano.SobranoVoron += 1;
            voron.SetActive(false);
        }
       




       


        //----------------------------------------------------------------------------
        //поворот персонажа
        tekTochkaX = GetComponent<Transform>().position.x;
        SpriteRenderer sp = GetComponent<SpriteRenderer>();

        if (tekTochkaX < proshTochkaX)
            sp.sprite = Resources.Load<Sprite>("Sprites/object/voron/voron");

        else
            sp.sprite = Resources.Load<Sprite>("Sprites/object/voron/voron2");

        proshTochkaX = tekTochkaX;
    }


   
}
