using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXAudioSource : MonoBehaviour
{
    // Reference to Audio Source component
    private AudioSource audioSrc;
    private AudioSource audioSrc1;
    private AudioSource audioSrc2;
    private bool isMuted;

    // Music volume variable that will be modified
    // by dragging slider knob
    private float musicVolume = 1f;

    // Use this for initialization
    void Start()
    {
        isMuted = false;
        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
        audioSrc1 = GetComponent<AudioSource>();
        audioSrc2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = musicVolume;
        audioSrc2.volume = musicVolume;
        audioSrc1.volume = musicVolume;
    }

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
    public void MutePressed()
    {

        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }
}


