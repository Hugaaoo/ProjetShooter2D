using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDopdown;


    Resolution[] resolutions;



    public void Start()
    {
        resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();
        resolutionDopdown.ClearOptions();


        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)

            {
                currentResolutionIndex = i;

            }
        }

        resolutionDopdown.AddOptions(options);
        resolutionDopdown.value = currentResolutionIndex;
        resolutionDopdown.RefreshShownValue();

    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }


    public void SetFullScreen(bool isFullScreen)

    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }
}
