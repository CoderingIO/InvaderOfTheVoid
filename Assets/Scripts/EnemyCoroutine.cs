using UnityEngine;
using System.Collections;

public class EnemyCoroutine : MonoBehaviour 
{
	public float fieldOfViewAngle = 110f;
	public bool playerInSight;

	public GameObject player;
	private Transform target;
	public SphereCollider col;
	public float attackDistance;
	public static int speed = 2;
	public bool attack = false;

	void Awake ()
	{
		player = GameObject.Find("ThirdPersonController");
		target = GameObject.Find("ThirdPersonController").transform;
		//StartCoroutine (Follow ());

	}





	void OnTriggerStay (Collider other)
	{
		// If the player has entered the trigger sphere...
		if (other.gameObject == player)
		{
			// By default the player is not in sight.
			playerInSight = false;

			// Create a vector from the enemy to the player and store the angle between it and forward.
			Vector3 direction = other.transform.position - transform.position;
			float angle = Vector3.Angle(direction, transform.forward);

			// If the angle between forward and where the player is, is less than half the angle of view...
			if (angle < fieldOfViewAngle * .5f)
			{
				RaycastHit hit;

				// ... and if a raycast towards the player hits something...
				if (Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius))
				{
					// ... and if the raycast hits the player...
					if (hit.collider.gameObject == player)
					{
						// ... the player is in sight.
						//playerInSight = true;
						playerInSight = true;
					}
				}
			}
		}
	}

	void OnTriggerExit (Collider other)
	{
		transform.LookAt(target);
	}
	
	
	void FixedUpdate ()
	{
		attackDistance = Vector3.Distance(transform.position, target.transform.position);

		if (playerInSight == true)
			StartCoroutine (Follow());

		//else if(attackDistance<2f)
		//	StartCoroutine (Attack());
	

	}
	
	IEnumerator Attack ()
	{	
		//while (Vector3.Distance(transform.position, target.position) <=2f)
		//{
		//StopCoroutine (Follow ());
		GetComponent<Animation>().Play(animation:"Attack_01");
		yield return new WaitForSeconds(3);
		//}
	}

	IEnumerator Follow ()
	{


		//yield return new WaitForSeconds (3);

		//attackDistance = Vector3.Distance(transform.position, target.transform.position);
		//Debug.Log(attackDistance);
		if (attackDistance > 2f)
		{	
			GetComponent<Animation>().Play(animation:"trollWalk");
			
			transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
			transform.LookAt(target);


		}
		
		if (attackDistance <= 2f)
		{
			yield return StartCoroutine (Attack());
		}

	
	}
	
}
