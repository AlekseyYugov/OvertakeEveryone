using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

public class Settings : MonoBehaviour
{
    [SerializeField] private Dropdown m_Resolution;
    [SerializeField] private Dropdown m_Quality;

    Resolution[] resolunions;

    private void Start()
    {
        m_Resolution.ClearOptions();
        List<string> options = new List<string>();
        resolunions = Screen.resolutions;
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolunions.Length; i++)
        {
            string option = resolunions[i].width + "x" + resolunions[i].height + " " + resolunions[i].refreshRate + "Hz";
            options.Add(option);
            if (resolunions[i].width == Screen.currentResolution.width && resolunions[i].height == Screen.currentResolution.height) 
            {
                currentResolutionIndex= i;
            }
        }
        m_Resolution.AddOptions(options);
        m_Resolution.RefreshShownValue();
        LoadSettings(currentResolutionIndex);
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolunions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingPreference", m_Quality.value);
        PlayerPrefs.SetInt("ResolutionPreference", m_Resolution.value);
    }
    public void LoadSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey("QualitySettingPreference")) m_Quality.value = PlayerPrefs.GetInt("QualitySettingPreference");
        else m_Quality.value = 5;
        if (PlayerPrefs.HasKey("ResolutionPreference")) m_Resolution.value = PlayerPrefs.GetInt("ResolutionPreference");
        else m_Resolution.value = currentResolutionIndex;
    }
}
