using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	Rigidbody2D rigidbody2D;
    public float speed = 2.0f;
    public float jump = 1000.0f;
    public bool grounded = true;
    public bool flip = true;
    SpriteRenderer spriterenderer;
    public int jumps = 3;
    public float dash = 0f;
    public float dashDelay;
    public float canDash;

    public bool dDown = false;
    public bool aDown = false;
    public bool sDown = false;
    public bool wDown = false;

    // Use this for initialization
    void Start ()
    {
    	dashDelay = Time.time;
        spriterenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
 }
 
 // Update is called once per frame
 void Update ()
    {
		

        if(Input.GetKey(KeyCode.D))
        {
            spriterenderer.flipX = false;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            spriterenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumps >= 1) //Om man trycker på space OCH den är "grounded", Hoppa
        {
            rigidbody2D.AddForce(Vector2.up * jump); //Hopp
            Debug.Log("jump!");
            jumps = jumps -1; //Grounded är false
        }
        float speedX = Input.GetAxis("Horizontal"); //Hastighet X

        rigidbody2D.velocity = new Vector2(speedX * speed, rigidbody2D.velocity.y); //Hastigheten på Horizontal och Vertical


        if (Input.GetKeyDown(KeyCode.D))
        {
        	dDown = true;
        }
		if (Input.GetKeyDown(KeyCode.A))
        {
        	aDown = true;
        }
		if (Input.GetKeyDown(KeyCode.W))
        {
        	wDown = true;
        }
		if (Input.GetKeyDown(KeyCode.S))
        {
        	sDown = true;
        }

		if (Input.GetKeyUp(KeyCode.D))
        {
        	dDown = false;
        }
		if (Input.GetKeyUp(KeyCode.A))
        {
        	aDown = false;
        }
		if (Input.GetKeyUp(KeyCode.W))
        {
        	wDown = false;
        }
		if (Input.GetKeyUp(KeyCode.S))
        {
        	sDown = false;
        }

		if (Input.GetKey(KeyCode.LeftShift) && dDown == true && dashDelay <= Time.time)
        {
        	transform.position = new Vector2 (transform.position.x + dash, transform.position.y);
        	dashDelay = Time.time + canDash;
        }

		if (Input.GetKey(KeyCode.LeftShift) && aDown == true && dashDelay <= Time.time)
        {
        	transform.position = new Vector2 (transform.position.x - dash, transform.position.y);
			dashDelay = Time.time + canDash;
		
        }

        if (Input.GetKey(KeyCode.LeftShift) && wDown == true && dashDelay <= Time.time)
        {
        	transform.position = new Vector2 (transform.position.x, transform.position.y + dash);
			dashDelay = Time.time + canDash;

        }

		if (Input.GetKey(KeyCode.LeftShift) && sDown == true && dashDelay <= Time.time)
        {
        	transform.position = new Vector2 (transform.position.x, transform.position.y - dash);
			dashDelay = Time.time + canDash;

        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "grounded")
        {
            jumps = 3;
        }
    }
}
