using UnityEngine;
using System.Collections;

public class destroyShot : MonoBehaviour {

	public float lifetime;
	
	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
	
}