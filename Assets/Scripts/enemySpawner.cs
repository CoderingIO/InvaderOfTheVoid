using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour 
{
	public GameObject enemy;
	public Vector3 spawnValues;
	public int enemyCount;
	//public float spawnWait;
	//public float startWave;
	//public float waveWait;
	public static int currentWave;


	void Start()
	{
		currentWave = 1;
		enemyCount = 2;
	}

	void Update()
	{
		if (healthDamage.currentEnemyCount <= 0)
		{
			for (int i = 0; i < enemyCount * currentWave; i ++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
				EnemyCoroutine.speed ++;
			}
			currentWave ++;
		}

	}

//	IEnumerator SpawnWaves ()
//	{
//		yield return new WaitForSeconds (startWave);
//
//		{
//
//
//
//				for (int i = 0; i < enemyCount * currentWave; i ++)
//				{
//					Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
//					Quaternion spawnRotation = Quaternion.identity;
//					Instantiate (enemy, spawnPosition, spawnRotation);
//					yield return new WaitForSeconds (spawnWait);
//					break;
//				}
//				yield return new WaitForSeconds (waveWait);
//				
//		}
//	}
}
