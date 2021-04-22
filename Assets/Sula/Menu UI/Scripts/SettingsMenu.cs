﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;  
    [SerializeField] TMP_Dropdown resDropdown;
    Resolution[] resolutions;

    private void Start()
    {
        GetResolution();
    }

    private void GetResolution()
    {
        resolutions = Screen.resolutions;
        resDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width 
                && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resDropdown.AddOptions(options);
        resDropdown.value = currentResolutionIndex;
        resDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        //audioMixer.SetFloat("volume", volume);
        if (volume == -40f)
        {
            audioMixer.SetFloat("volume", -80);
        }
        else
        {
            audioMixer.SetFloat("volume", volume);
        }
    }

    public void SetResolution()
    {

    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
