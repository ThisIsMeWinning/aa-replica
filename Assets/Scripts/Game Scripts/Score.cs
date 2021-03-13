using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int PinCount;

	public Text text;
	public Text userName;
	public Text highScore;


	void Start ()
	{
		PinCount = 0;
	}

	void Update ()
	{
		text.text = PinCount.ToString();
		userName.text = PlayerPrefs.GetString("UserName");
		highScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString();
	}

}
