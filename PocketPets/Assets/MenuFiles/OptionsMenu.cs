using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private TextMeshProUGUI volumeTextUI = null;

    private void Start() //bet�lti az el�z�leg elmentett hanger�t megnyit�skor
    {
        LoadValues();
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.0");
    }

    public void SetVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    public void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        //AudioListener.volume = volumeValue;
        audioMixer.SetFloat("VolumeValue", volumeValue);
    }

    public AudioMixer audioMixer;


    /*
    public void SetVolume(float volume)
    {
        //az audiomixer param�tereinek r�hookol�sa k�ddal hogy lehessen mozhatni a sliderrel
        audioMixer.SetFloat("volume", volume);
        Debug.Log(volume);
    }
    */
}