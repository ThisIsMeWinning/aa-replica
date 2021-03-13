using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    public void Start()
    {

        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i =0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        
    }

    public void SetResolution(int resolutionIndex) 
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Stop("Menu1");
        int rand = Random.Range(1, 7);
        FindObjectOfType<AudioManager>().Play("Rock" + rand.ToString());
        SceneManager.LoadScene("MainLevel");

    }

    public void OpenURL()
    {
        Application.OpenURL("https://github.com/ThisIsMeWinning/aa-replica");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }

    public void PlayClick()
    {
        FindObjectOfType<AudioManager>().Play("Click");
    }


    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void ChangePinSpeed(float val)
    {
        Pin.speed = val;
    }
    public void ChangeRotatorSpeed(float val)
    {
        Rotator.speed = val;
    }

    public void SetUserName(string username)
    {
        PlayerPrefs.SetString("UserName", username);
    }

}
