using UnityEngine;
using System.Collections;

public class ChargedGun : BaseWeapon 
{

	public ChargedGun ()
	{
		ammo = 50;
		damage = 40;
		clipSize = 10;
		clip = 10;
	}

	public override void Shoot ()
	{
		Debug.Log ("BZZZAP");
	}

	public override void PickUp ()
	{
		Debug.Log ("You attatch the ChargedGun to your hand.");
	}

	public override void Drop ()
	{
		Debug.Log ("This should probably not be on your hand. Drops the ChargedGun.");
	}

	public override string GetDescription ()
	{
		return "This gun is toxic!";
	}
}


