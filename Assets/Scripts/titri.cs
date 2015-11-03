using UnityEngine;
using System.Collections;

public class titri : MonoBehaviour {

    private float titriSpeed = 1;
    public Rigidbody2D rb;

    private void OnMouseDown()
    {

        Application.LoadLevel("GameMenu");
    }

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
       if(GetComponent<Transform>().position.y < 16)
            rb.velocity = new Vector2(0, titriSpeed);

       if (GetComponent<Transform>().position.y > 15)
            Application.LoadLevel("GameMenu");
    }
}
