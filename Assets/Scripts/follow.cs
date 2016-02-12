//using UnityEngine;
//using System.Collections;
//
//public class follow : MonoBehaviour 
//{
//	public float speed;
//	private Transform target;
//	public float attackDistance;
//
//	void Awake ()
//	{
//		target = GameObject.Find("ThirdPersonController").transform;
//
//	}
//
//	void Start ()
//	{
//
//	}
//
//	void Update ()
//	{
//		transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
//		transform.LookAt(target);
//
//		attackDistance = Vector3.Distance(transform.position, target.transform.position);
//		Debug.Log(attackDistance);
//
//
//		//This part of the script is to switch animations between moving and attacking
//		//Check to find distance from target
//
//		if (attackDistance <= 3)
//		{
//
//			GetComponent<Animation>().Play(animation:"Attack_01");
//			speed = 0;
//
//		}
//		if (attackDistance >= 3)
//		{
//			GetComponent<Animation>().Play(animation:"trollWalk");
//		}
//
//	}
//
//}
