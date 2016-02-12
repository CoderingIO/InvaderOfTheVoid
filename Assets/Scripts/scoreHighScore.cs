using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class scoreHighScore : MonoBehaviour
{
	public Text[] scoreText;
	public Text[] playerName;
	public static scoreHighScore instance;
	
	void Awake()
	{
		//		playerName = PlayerPrefs.GetString ("Player_Name");
		instance = this;
		
		// Julien notes:
		// assign playerName to text value on Text component
		
		// for saving player value, use PlayerPrefs.GetInt and PlayerPrefs.SetInt
		// you can convert it to a string to display by using myInt int; int.ToString()
		
		// If the value is found, it is passed back to charName.  Should this go in the Start method?
		// or with a default value if the key Character_Name can not be found
		// playerName = PlayerPrefs.GetString ("Player_Name", "NoName"); 
	}
	
	void Update()
	{
		//charText.text = playerName; 
		// this seems silly, you should put this in start?
	}
	
	public void CharName()
	{
		List<Scores> allScores = highScoreManager.GetHighScore ();
		
		for (int i = 0; i < playerName.Length && i < allScores.Count; i++) {
			Debug.Log("For index " + i + ", name is " + allScores[i].name + ", score is " + allScores[i].score);
			playerName[i].text = allScores [i].name;
			
			scoreText[i].text = allScores[i].score.ToString();
			
		}
	}
	
	
	//	PlayerPrefs.Save();
	
}
