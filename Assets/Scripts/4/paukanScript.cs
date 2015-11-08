using UnityEngine;
using System.Collections;

public class paukanScript : MonoBehaviour {

    //----------------------------------------------------------------------------
    //исчезновение при касании приведением
    public GameObject pauk;
    public int HpPauka = 2;

    //----------------------------------------------------------------------------
    //отскок от игрока
    private float otprig = 0;
    private float proshpaukX = 1f;

    public SchetchikHeals heals;
    public ShetchicPaukov ShetchicPaukov;
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
    //связь с игроком
    public Transform _playerTransform;

    private float playerX = 1f;
    
    

    public Rigidbody2D rb;

    public float paukSpeed = 1f;

    public imapauka ima;

    public AudioClip PaukSound;

    private void Start()
    {
        //----------------------------------------------------------------------------
        //связь с игроком
        rb = GetComponent<Rigidbody2D>();

        proshpaukX = GetComponent<Transform>().position.x;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (heals.Heals > 0)
            {
                heals.Heals -= 1;
                otprig = 1;

            }

        }

        if (other.tag == "abigail")
        {
            GetComponent<AudioSource>().PlayOneShot(PaukSound);
            if (HpPauka == 0)
            {
                pauk.SetActive(false);
                ShetchicPaukov.SobranoPaukov += 1;
            }
            else
                HpPauka -= 1;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            otprig = 0;

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

            float paukX = GetComponent<Transform>().position.x;
            float paukY = GetComponent<Transform>().position.y;
           

            if (ima.imaPauka == name)//имя глоб перем и имя ворона
            {
                if (playerX < paukX)
                    transform.position = new Vector3(paukX - 1, paukY + 3, 0);

                if (playerX > paukX)
                    transform.position = new Vector3(paukX + 1, paukY + 3, 0);
            }

            
                if (playerX < paukX)
                    rb.velocity = new Vector2(-paukSpeed, 0);

                else
                    rb.velocity = new Vector2(paukSpeed, 0);

            

            //----------------------------------------------------------------------------------
            //отпрыг паука
            if (otprig == 1)
            {
                if (GetComponent<Transform>().position.x > proshpaukX)
                    transform.position = new Vector3(paukX - 1, paukY, 0);
                else
                    transform.position = new Vector3(paukX + 1, paukY, 0);

                proshpaukX = GetComponent<Transform>().position.x;
            }
        }
    }
}
