using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject intro;

    public void Start()
    {
        //For random song
        //int rand = Random.Range(1, 4);
        //FindObjectOfType<AudioManager>().Play("Menu" + rand.ToString());
        FindObjectOfType<AudioManager>().Play("Menu1");
    }
    void Update()
    {
        if(Input.anyKey)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            intro.SetActive(false);
            mainMenu.SetActive(true);
        }
        
    }
}
