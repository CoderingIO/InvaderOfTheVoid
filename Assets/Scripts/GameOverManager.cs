using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameOverManager : MonoBehaviour
{
	public playerHealth health;      		 // Reference to the player's health.
	public float restartDelay = 5f;         // Time to wait before restarting the level
	public Text gameOver;
	private GameObject body;
	public Animation gameOverAnim;
	public static bool isDead;


	
	Animator anim;                          // Reference to the animator component.
	float restartTimer;                     // Timer to count up to restarting the level
	
	
	void Awake ()
	{
		// Set up the reference.
		//anim = GetComponent <Animator> ();
	}
	
	//bool isDead = false;
	
	void Update ()
	{
		// If the player has run out of health...
		if(playerHealth.health <= 0)
		{
			isDead = true;
				// ... tell the animator the game is over.
				//anim.SetTrigger ("GameOver");
			body = GameObject.Find("EthanBody");
			Destroy(body);



				string playerName = PlayerPrefs.GetString("playerName");
				int score = healthDamage.KillCount;
				highScoreManager.SaveHighScore(playerName, score);
				scoreHighScore.instance.CharName();
				StartCoroutine(GameOver());
		}

	}

	IEnumerator GameOver ()
	{
		gameOver.enabled = true;
		//gameOverAnim.enabled = true;

		yield return new WaitForSeconds(5);
		Application.LoadLevel("High Scores");

				
				// .. increment a timer to count up to restarting.
				//	restartTimer += Time.deltaTime;
				
				// .. if it reaches the restart delay...
				//	if(restartTimer >= restartDelay)
				//	{
				// .. then reload the currently loaded level.
				//Application.LoadLevel(Application.loadedLevel);
	}


}

