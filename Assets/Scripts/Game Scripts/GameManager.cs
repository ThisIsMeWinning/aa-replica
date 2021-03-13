using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner spawner;
	public GameObject endMenu;

	public Animator animator;

	public void EndGame ()
	{
		if(Score.PinCount > PlayerPrefs.GetInt("HighScore", 0))
        {
			PlayerPrefs.SetInt("HighScore", Score.PinCount);
		}
		

		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;
		FindObjectOfType<AudioManager>().StopAll();

		animator.SetTrigger("EndGame");

		gameHasEnded = true;

		endMenu.SetActive(true);
		FindObjectOfType<AudioManager>().Play("Menu1");
	}

	public void RestartLevel ()
	{
		FindObjectOfType<AudioManager>().StopAll();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		int rand = Random.Range(1, 7);
		FindObjectOfType<AudioManager>().Play("Rock" + rand.ToString());
	}


}
