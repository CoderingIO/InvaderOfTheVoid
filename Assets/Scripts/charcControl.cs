using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]

public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class charcControl : MonoBehaviour
{
	public Animator animator;
	public float moveSpeed;
	public Boundary boundary;
	public float turnSpeed = 2.0f;
	public AudioClip death;
	public Text killcount;



	void Start ()
	{
		healthDamage.KillCount = 0;
		animator = GetComponent<Animator>();

	}

	void FixedUpdate ()
	{
		if(!GameOverManager.isDead)
		{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			animator.SetFloat("speed", moveVertical);
			if (moveVertical < 0)
				{
				animator.SetFloat("speed", -moveVertical);
				}
		
			Vector3 movement = transform.forward * moveVertical;
			GetComponent<Rigidbody>().velocity = movement * moveSpeed;

			transform.rotation *= Quaternion.Euler (0f, moveHorizontal * turnSpeed, 0f);


		
			GetComponent<Rigidbody>().position = new Vector3 
				(
					Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
					0.0f, 
					Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
					);

	
		}
	}

	void Update()
	{
		killcount.text = "Enemies Defeated " + healthDamage.KillCount.ToString();
	}





	





//	void OnTriggerEnter (Collider other)
//	{
//		if (other.gameObject.tag == "enemy")
//			{
//			Application.LoadLevel(0);
//			}
//	}
}

