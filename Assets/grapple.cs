using UnityEngine;
using System.Collections;

public class grapple : MonoBehaviour {

	public Transform grape;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.R))
		{

			Instantiate (grape, new Vector2(transform.position.x + 0.1f, transform.position.y), Quaternion.identity);


		}
	}
}
