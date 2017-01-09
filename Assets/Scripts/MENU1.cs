﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MENU1 : MonoBehaviour
{
    //public GameObject mainMenuHolder;
    public GameObject optionsMenuHolder;
    public Slider[] volumeSliders;
    public Toggle[] resolutionToggles;
    public int[] screenWidths;
    int activeScreenResIndex;

   void Start()
    {
        activeScreenResIndex = PlayerPrefs.GetInt("screen res index");
        bool isfullscreen = (PlayerPrefs.GetInt("fullscreen")==1)?true:false;
        volumeSliders[0].value = AudioManager.instance.masterVolumePercent;
        volumeSliders[1].value = AudioManager.instance.musicVolumePercent;
        volumeSliders[2].value = AudioManager.instance.sfxVolumePercent;
        for(int i=0;i<resolutionToggles.Length;i++)
        {
            resolutionToggles[i].isOn = i == activeScreenResIndex;

        }
        SetFullScreen(isfullscreen);
    }
    public void OptionsMenu()
    {
        //  mainMenuHolder.SetActive(false);
        optionsMenuHolder.SetActive(true);
    }

    public void SetScreenResolution(int i)
    {
        if (resolutionToggles[i].isOn)
        {
            activeScreenResIndex = i;
            float aspectRatio = 16 / 9f;
            Screen.SetResolution(screenWidths[i], (int)(screenWidths[i] / aspectRatio), false);
            PlayerPrefs.SetInt("screen res index", activeScreenResIndex);
            PlayerPrefs.Save();
        }

    }
    public void SetFullScreen(bool isfullscreen)
    {
        for (int i = 0; i < resolutionToggles.Length; i++)
        {

            resolutionToggles[i].interactable = !isfullscreen;
        }
        if (isfullscreen)
        {
            Resolution[] allResolutions = Screen.resolutions;
            Resolution maxResolution = allResolutions[allResolutions.Length - 1];
            Screen.SetResolution(maxResolution.width, maxResolution.height, true);
        }
        else
        {
            SetScreenResolution(activeScreenResIndex);

        }
        PlayerPrefs.SetInt("FullScreen", ((isfullscreen) ? 1 : 0));
        PlayerPrefs.Save();
    }
    public void SetMasterVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Master);
    }
    public void SetMusicVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Music);
    }
    public void SetSFXVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Sfx);
    }
    public void SetBackButton()
    {
        SceneManager.LoadScene("MAINPAGE");
    }


}

