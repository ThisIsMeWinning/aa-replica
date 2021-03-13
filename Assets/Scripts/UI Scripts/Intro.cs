using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject intro;
    public Text highScore;

    public void Start()
    {
        //For random song
        //int rand = Random.Range(1, 4);
        //FindObjectOfType<AudioManager>().Play("Menu" + rand.ToString());
        FindObjectOfType<AudioManager>().Play("Menu1");
        
    }
    void Update()
    {
        highScore.text = PlayerPrefs.GetString("UserName") + " - " + PlayerPrefs.GetInt("HighScore").ToString();
        if (!Input.GetKey("d"))
        {
            if (Input.anyKey)
            {
                FindObjectOfType<AudioManager>().Play("Click");
                intro.SetActive(false);
                mainMenu.SetActive(true);
            }
        }


        if(Input.GetKey("d"))
        {
            PlayerPrefs.DeleteKey("HighScore");
            //PlayerPrefs.DeleteKey("UserName");
        }
        
    }
}
