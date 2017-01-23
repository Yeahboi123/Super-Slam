using UnityEngine;
using System.Collections;

public class ClassUser : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		LazerGun laser = new LazerGun ();
		laser.Shoot ();
		BaseWeapon someWeapon = new LazerGun();
		someWeapon.PickUp ();
		someWeapon.Reload ();
		Debug.Log ("There is " + someWeapon.GetAmmo ().ToString () + " ammo left");
		someWeapon.Shoot ();
		Debug.Log (someWeapon.GetDescription ());
		someWeapon.Drop ();

		ChargedGun charged = new ChargedGun ();
		charged.Shoot ();
		BaseWeapon thisWeapon = new ChargedGun ();
		thisWeapon.PickUp ();
		thisWeapon.Reload ();
		Debug.Log ("There is " + thisWeapon.GetAmmo ().ToString () + " ammo left");
		thisWeapon.Shoot ();
		Debug.Log (thisWeapon.GetDescription ());
		thisWeapon.Drop ();

		Glock glock = new Glock ();
		glock.Shoot ();
		BaseWeapon anotherWeapon = new Glock ();
		anotherWeapon.PickUp ();
		anotherWeapon.Reload ();
		Debug.Log ("There is " + anotherWeapon.GetAmmo ().ToString () + " ammo left");
		anotherWeapon.Shoot ();
		Debug.Log (thisWeapon.GetDescription ());
		anotherWeapon.Drop ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
