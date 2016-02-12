using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour 
{
	public static float health;
	public float damage;
	//public GameObject hitBox;
	public Rigidbody rb;
	public float thrust;
	public AudioClip slap;
	public static bool isDead;

	void Start ()
	{
		isDead = false;
		health = 1f;
		damage = .1f;

		rb = GetComponent<Rigidbody>();

	}
	
	void Update ()
	{
		Material mat = GetComponentInChildren<Renderer>().material;
		Color newColor = new Color (health,health,health);
		mat.SetColor("_EmissionColor", newColor);



		if (health <= 0)
		{
			isDead = true;

		
		}

	}

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "hitBox")
		{

			health -= damage;
			rb.AddForce(transform.forward * thrust);

			GetComponent<AudioSource>().clip = slap;
			GetComponent<AudioSource>().Play();

		}
	}


	//IEnumerator PlayerDeath()
	//{
	//	GetComponent<Animation>().Play(animation:"HumanoidFall");
	//
	//	yield return new WaitForSeconds(1);
	//}
}
