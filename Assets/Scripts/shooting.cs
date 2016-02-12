using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shooting : MonoBehaviour 
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float speed;
	public Text score;
	private float nextFire;
	public static int numberOfLights;


	void Start ()
	{
		numberOfLights = 10;
	}



	void Update ()
	{
		{
			score.text = "You have " + shooting.numberOfLights.ToString() + " lights.";			
			if (Input.GetKeyDown("space") && Time.time > nextFire && numberOfLights >= 1)
			{
				nextFire = Time.time + fireRate;
				Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
				numberOfLights --;
				score.text = "You have " + numberOfLights.ToString() + " lights.";
			}

		}
	}
}