using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class printHighScores : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		string playerName = PlayerPrefs.GetString("playerName");
		int score = healthDamage.KillCount;
		highScoreManager.SaveHighScore(playerName, score);
		scoreHighScore.instance.CharName();
	}
	

}
