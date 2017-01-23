using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {
	public Transform punch;
	public float DestroyPunch;
	public float PunchDelay;
	public float CanPunch;
	public float KillPunch;

	// Use this for initialization
	void Start () 
	{
		DestroyPunch = Time.time;
		CanPunch = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{




		if (Input.GetKeyDown(KeyCode.F) && Time.time >= CanPunch)
		{

			Instantiate (punch, new Vector2(transform.position.x + 0.4f, transform.position.y), Quaternion.identity);
			DestroyPunch = Time.time + KillPunch;
			CanPunch = Time.time + PunchDelay;
		}

		if (DestroyPunch <= Time.time)
		{
			Destroy(GameObject.FindWithTag("punch")); 
		}


	
	}
		
}
