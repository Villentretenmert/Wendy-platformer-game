using UnityEngine;
using System.Collections;

public class pchelaScript : MonoBehaviour {

    public SchetchikHeals heals;
    public float pchelaSpeed = 1f;

    private float nachTochkaX = 1f;
    private float nachTochkaY = 1f;

    private float tekTochkaX = 1f;
    private float tekTochkaY = 1f;

    private float proshTochkaX = 1f;
    private float proshTochkaY = 1f;

    public Rigidbody2D rb;

    //-----------------------------------------------------------------------
    //проигрывание звука при приближении
   
    public AudioClip pchelaSound;
    


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (heals.Heals > 0)
            {
                heals.Heals -= 1;
                GetComponent<AudioSource>().PlayOneShot(pchelaSound);
            }
                      

        }
    }


    

    private void Start()
    {
        nachTochkaX = GetComponent<Transform>().position.x;
        proshTochkaX = nachTochkaX;

        nachTochkaY = GetComponent<Transform>().position.y;
        proshTochkaY = nachTochkaY;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        

        SpriteRenderer sp = GetComponent<SpriteRenderer>();

        tekTochkaX = GetComponent<Transform>().position.x;
        tekTochkaY = GetComponent<Transform>().position.y;

        float otnositPositionX = tekTochkaX - nachTochkaX;
        float otnositPositionY = tekTochkaY - nachTochkaY;

        float znakX = 1;
        float znakY = 1;
        if (Random.value < 0.5)
            znakX = -1;

        if (Random.value < 0.5)
            znakY = -1;

        if (otnositPositionX < 3 && otnositPositionX > -3)
        {
            if (otnositPositionY < 2 && otnositPositionY > -2)
                GetComponent<Rigidbody2D>().AddForce(new Vector2(pchelaSpeed* znakX, pchelaSpeed* znakY));

           

            if (otnositPositionY > 2)
                rb.velocity = new Vector2(pchelaSpeed * znakX, -pchelaSpeed );
            

            if (otnositPositionY < -2)
                rb.velocity = new Vector2(pchelaSpeed * znakX, pchelaSpeed );
            
        }

        if (otnositPositionX > 3)
        {
            if (otnositPositionY < 2 && otnositPositionY > -2)
                rb.velocity = new Vector2(-pchelaSpeed , pchelaSpeed * znakY);
            

            if (otnositPositionY > 2)
                rb.velocity = new Vector2(-pchelaSpeed, -pchelaSpeed);
            

            if (otnositPositionY < -2)
                rb.velocity = new Vector2(-pchelaSpeed, pchelaSpeed);
            
        }


        if (otnositPositionX < -3)
        {
            if (otnositPositionY < 2 && otnositPositionY > -2)
                rb.velocity = new Vector2(pchelaSpeed , pchelaSpeed * znakY);
           

            if (otnositPositionY > 2)
                rb.velocity = new Vector2(pchelaSpeed , -pchelaSpeed);
            

            if (otnositPositionY < -2)
                rb.velocity = new Vector2(pchelaSpeed, pchelaSpeed);
           
        }


        if (tekTochkaX < proshTochkaX)
            sp.sprite = Resources.Load<Sprite>("Sprites/object/pchela/1pch2");

        else
            sp.sprite = Resources.Load<Sprite>("Sprites/object/pchela/1pch1");

        proshTochkaX = tekTochkaX;

    }

}
