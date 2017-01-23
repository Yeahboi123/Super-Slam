﻿using UnityEngine;
using System.Collections;

public class LazerGun : BaseWeapon 
{

	public LazerGun ()
	{
		ammo = 200;
		damage = 20;
		clipSize = 100;
		clip = 100;
	}

	public override void Shoot ()
	{
		Debug.Log ("WOOOSH");
		base.Shoot ();
	}

	public override void PickUp ()
	{
		Debug.Log ("Picked up a lazergun");
	}

	public override void Drop ()
	{
		Debug.Log ("Dropped the laser gun");
	}

	public override string GetDescription ()
	{
		return "It's a very nice lazergun";
	}
}
