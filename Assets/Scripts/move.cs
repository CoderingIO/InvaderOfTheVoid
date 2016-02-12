using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed;


	void Start ()
	{
		GetComponent<AudioSource>().Play ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(0, 0, Time.deltaTime);

	}
}
