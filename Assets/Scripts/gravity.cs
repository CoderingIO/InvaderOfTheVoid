using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour
{
	public Rigidbody rb;
	public Transform player;
	public Transform planet;
	public float force = 1f;

	void start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () 
	{
		rb.AddForce((planet.position  - player.position) * force);



	}
}
