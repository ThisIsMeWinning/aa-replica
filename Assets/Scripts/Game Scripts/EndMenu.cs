using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayGame()
    {
        FindObjectOfType<GameManager>().RestartLevel();

    }

    public void PlayClick()
    {
        FindObjectOfType<AudioManager>().Play("Click");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Main");
    }
}
