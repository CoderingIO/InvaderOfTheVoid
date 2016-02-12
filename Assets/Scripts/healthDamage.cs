using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthDamage : MonoBehaviour
{
	public float damage;
	public float enemyHealth;
	public float rate;
	public AudioClip burn;
	public GameObject sparkDamage;
	//public Slider slider;
	public static int KillCount;
	public static int currentEnemyCount;
	public int totalHealth;



	// Use this for initialization
	void Start ()
	{

		enemyHealth = 0f;
		currentEnemyCount ++;

	}


	void Update ()
	{
		Renderer [] renderers = GetComponentsInChildren<Renderer>();
//		Material [] materials = new Material[renderers.Length];
		foreach (Renderer rend in renderers) // (int i = 0; i < renderers.Length; i++)
		{
			for (int j = 0; j < rend.materials.Length; j++)
			{
			//materials[j] = renderers[i].materials;
			Color newColor = new Color (enemyHealth/totalHealth,enemyHealth/totalHealth,enemyHealth/totalHealth);
			rend.materials[j].SetColor("_EmissionColor", newColor);
			}
		}

	
		if (enemyHealth >= totalHealth)
		{
			Destroy (gameObject);
			KillCount ++;
			currentEnemyCount --;

		}

		//slider.value = enemyHealth;


	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "projectile")
		{
			GetComponent<AudioSource>().clip = burn;
			GetComponent<AudioSource>().Play();
			sparkDamage.SetActive(true);
		}
	}

	// I am trying only to take damage when its hit by the projectile.
	void OnTriggerStay (Collider other)
	{
		        
		if (other.gameObject.tag == "projectile")
		{
			enemyHealth += damage * rate * Time.deltaTime;
				
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "projectile")
		{
			sparkDamage.SetActive(false);
			GetComponent<AudioSource>().Stop();
		}
	}
}


