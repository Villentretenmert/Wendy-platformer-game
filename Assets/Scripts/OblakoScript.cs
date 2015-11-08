using UnityEngine;
using System.Collections;

public class OblakoScript : MonoBehaviour {
    
    private float OblakoSpeed = 1f;
    public float MnogOblakoSpeed = 1f;
    private float spawnPoint;
    public Rigidbody2D rb;

    void Start ()
    {
        OblakoSpeed = Random.Range(0f,1f);
        spawnPoint = GetComponent<Transform>().position.y;
        rb = GetComponent<Rigidbody2D>();
    }
	
	
	void Update () {
         
       if (GetComponent<Transform>().position.x > -40)
        {
            rb.velocity = new Vector2(-MnogOblakoSpeed * OblakoSpeed, 0);
        }
        else
        {
            
            transform.position = new Vector3(40, spawnPoint, 5);

        }

    }
}
