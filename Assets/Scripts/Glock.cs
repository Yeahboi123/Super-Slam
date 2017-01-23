using UnityEngine;
using System.Collections;

public class Glock : BaseWeapon {
	

	public Glock ()
	{
		ammo = 20;
		damage = 40;
		clipSize = 8;
		clip = 8;
	}

	public override void Shoot ()
	{
		Debug.Log ("PANG");
	}

	public override void PickUp ()
	{
		Debug.Log ("The Glock gets pickedup from the ground.");
	}

	public override void Drop ()
	{
		Debug.Log ("This weapon is useless compared to the ChargedGun.");
	}

	public override string GetDescription ()
	{
		return "Nomral Handgun.";
	}
}
