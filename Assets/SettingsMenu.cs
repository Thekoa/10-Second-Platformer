using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer _audioMixer;
    
    public Dropdown resDropDown;

    Resolution[] resolutions;

    void Start() 
    {
        resolutions = Screen.resolutions;

        resDropDown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resDropDown.AddOptions(options);
    }

    public void SetVolume (float volume)
    {
        _audioMixer.SetFloat("Volume", volume);
    }

    public void FullscreenSet (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
