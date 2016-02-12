using UnityEngine;
using System.Collections;

public class lightspawner : MonoBehaviour
{
	public GameObject lightSpawner;
	public Vector3 lightSpawnValues;
	public int lightCount;
	public float lightSpawnWait;
	public float lightWaveWait;
	public float lightStartWave;


	void Start ()
	{
		lightCount = 2;
	}

	void Update ()
	{
		if (healthDamage.currentEnemyCount <= 0)
		{
			for (int i = 0; i < lightCount * enemySpawner.currentWave; i ++)
			{
				Vector3 lightSpawnPosition = new Vector3 (Random.Range(-lightSpawnValues.x, lightSpawnValues.x), lightSpawnValues.y, Random.Range(-lightSpawnValues.z, lightSpawnValues.z));
				Quaternion lightSpawnRotation = Quaternion.identity;
				Instantiate (lightSpawner, lightSpawnPosition, lightSpawnRotation);
			}
		}
	}
}
