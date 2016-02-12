using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loadMainMenu : MonoBehaviour 
{

	public void OnClickEnter ()
	{
		Application.LoadLevel("InvaderTitleScreen");
	}

}
