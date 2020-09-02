using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScore : MonoBehaviour
{
    
	public Text Highscore;
	
	public void Reset()
	{
		PlayerPrefs.DeleteAll(); // deletes all saved records
		Highscore.text = "0"; // the number you want to reset your highscore to..
	}
}
