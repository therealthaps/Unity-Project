using UnityEngine;

public class AudioMixer : MonoBehaviour
{

    // Reference to Audio Source component
    private AudioSource[] audioSrcArr;
    private bool isMuted;
    public bool gameOver;
    public bool isTheme;

    // Music volume variable that will be modified
    // by dragging slider knob
    private float musicVolume = 1f;

    // Use this for initialization
    void Start()
    {
        isMuted = false;
        audioSrcArr = GetComponents<AudioSource>();
        // Assign Audio Source component to control it
        if (isTheme)
        {
            audioSrcArr[0].Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrcArr[0].volume = musicVolume;
        if (gameOver && !audioSrcArr[1].isPlaying)
        {
            audioSrcArr[0].Stop();
            GameOverMusic();
        }
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
    private void GameOverMusic()
    {
        audioSrcArr[1].Play();
    }
}