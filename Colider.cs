using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour

{

	
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(this.name+" Collided with " + other.name);
	}	
	
	/*
	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log(this.name+" Collided with " + collision.gameObject.name);
	}	
	*/
}
