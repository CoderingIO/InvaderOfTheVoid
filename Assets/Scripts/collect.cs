using UnityEngine;
using System.Collections;
using UnityEngine.UI;




public class collect : MonoBehaviour 
{
	




	

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			shooting.numberOfLights +=  5;
		
		}

	}
}
