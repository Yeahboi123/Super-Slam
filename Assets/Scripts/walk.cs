using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class walk : MonoBehaviour {

    private float movex = 0f;
    private float movey = 0f;
    public float speed = 0f;
    public bool grounded;
    public float jump = 0;
    public int jumps = 3;

	SpriteRenderer spriterenderer;
	Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start ()
    {
   		spriterenderer = GetComponent<SpriteRenderer>();
		rigidbody2D = GetComponent<Rigidbody2D>();

		grounded = false; 
    }
	
	// Update is called once per frame
	void Update ()
    {
        movex = Input.GetAxis("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * speed, rigidbody2D.velocity.y * speed);

		if (Input.GetKey(KeyCode.A))
   		{
    		spriterenderer.flipX = true;
    	}

		if (Input.GetKey(KeyCode.D))
   		{
    		spriterenderer.flipX = false;
    	}

    	if (Input.GetKeyDown(KeyCode.Space) && jumps >= 1)
    	{
    		rigidbody2D.AddForce(Vector2.up * jump);
    		jumps = jumps - 1;
    	}



    }

	void OnCollisionEnter2D (Collision2D coll)
    {
    	if (coll.gameObject.tag == "grounded")
    	{
    		jumps = 3;
    		grounded = true;
    	}
    }
 
}
