using UnityEngine;
using System.Collections;

public class konez : MonoBehaviour
{

    
        private float titriSpeed = 1;
        public Rigidbody2D rb;

    private void OnMouseDown()
    {
        
            Application.LoadLevel("GameTitri");
    }

    void Start()
        {

            rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {

            if (GetComponent<Transform>().position.y < 9)
                rb.velocity = new Vector2(0, titriSpeed);

            if (GetComponent<Transform>().position.y > 8)
                Application.LoadLevel("GameTitri");
        }
    }
