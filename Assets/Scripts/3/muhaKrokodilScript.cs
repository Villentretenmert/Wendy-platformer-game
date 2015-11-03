using UnityEngine;
using System.Collections;

public class muhaKrokodilScript : MonoBehaviour {
    private float tekTochkaX = 1f;
    private float proshTochkaX = 1f;
    //----------------------------------------------------------------------------
    //связь с игроком
    public Transform _playerTransform;
    public float playerY = 1f;
    
    public float MuhaSpeed = -1f;
    
    private float spawnPoint;
    public Rigidbody2D rb;

    public SchetchikHeals heals;

    public AudioClip muhaSound;


    void OnBecameVisible()
    {
        GetComponent<AudioSource>().PlayOneShot(muhaSound);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (heals.Heals > 0)
            {
                heals.Heals -= 1;

            }

        }
    }

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        playerY = _playerTransform.position.y;
        spawnPoint = playerY;
        transform.position = new Vector3(40, spawnPoint, -1);
        proshTochkaX = GetComponent<Transform>().position.x;
    }


    void FixedUpdate()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        if (GetComponent<Transform>().position.x > 40)
        {
            sp.sprite = Resources.Load<Sprite>("Sprites/object/voron/muha");
            playerY = _playerTransform.position.y;
            spawnPoint = playerY;
            transform.position = new Vector3(40, spawnPoint, -1);
            MuhaSpeed = -MuhaSpeed;
            
        }
        if (GetComponent<Transform>().position.x <-40)
        {
            sp.sprite = Resources.Load<Sprite>("Sprites/object/voron/muha2");
            playerY = _playerTransform.position.y;
            spawnPoint = playerY;
            transform.position = new Vector3(-40, spawnPoint, -1);
            MuhaSpeed =-MuhaSpeed;
            
        }

        rb.velocity = new Vector2(MuhaSpeed, 0);

       
    }
}
