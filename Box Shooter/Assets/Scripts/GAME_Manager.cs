using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAME_Manager : MonoBehaviour
{
	public static GAME_Manager gm1;
	
	public InputField PlayerName;
	public Text highScoreDisplay ;
	public Text highScorePlayerNameDisplay ;
	public int highScore;
	public string highScorePlayerName="UNKNOWN";
	//public int score;
	
    // Start is called before the first frame update
    public void Update()
    {
       highScore = PlayerPrefs.GetInt("highestScore");
	   
	   PlayerPrefs.SetString("highestScore_PlayerName", PlayerName.text);
	   highScorePlayerName = PlayerPrefs.GetString("highestScore_PlayerName");
	   
	   highScoreDisplay.text = highScore.ToString();
	   highScorePlayerNameDisplay.text = highScorePlayerName.ToString();
    }
	public void ResetScoreFun(){
		PlayerPrefs.DeleteKey("highestScore");
		highScoreDisplay.text ="0"; //PlayerPrefs.SetInt(GameManager.gm.highScoreKey, 0).ToString();
	}
    
}
