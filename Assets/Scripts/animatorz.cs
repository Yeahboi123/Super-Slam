using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class animatorz : MonoBehaviour 
{
	public float waitTime;
	public float delay = 0f;
	public int index;
	public List<Sprite> spriteList;
	SpriteRenderer spriterenderer;
	public bool playing;

     void Start ()
    {
    	delay = Time.time;
    	playing = false;
     	spriterenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
    	//if (Input.GetKeyDown(KeyCode.D))
    	//{
    		//playing = true;
    	//}

		//if (Input.GetKeyDown(KeyCode.A))
    	//{
    		//playing = true;
    	//}

		if (Input.GetKeyUp(KeyCode.A))
    	{
    		playing = false;
    	}

		if (Input.GetKeyUp(KeyCode.D))
    	{
    		playing = false;
    	}

		if(Input.GetKeyDown(KeyCode.Space))
        {
           playing = true;
        }


    	if(delay <= Time.time && playing == true)
    	{
    		spriterenderer.sprite = spriteList [index];
    		index++;

    		if (index >= spriteList.Count)
    		{
    			index = 0;
    		}

    		delay = Time.time + waitTime;
  		}


	}


}

