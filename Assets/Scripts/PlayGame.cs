using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {
	
	public InputField playerName;
	
	
	public void OnClickEnter () 
	{
		PlayerPrefs.SetString("playerName", playerName.text);
		Application.LoadLevel ("MainLevel");
	}
}