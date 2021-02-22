using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    private AudioMixer aud;
    public GameObject endgamescreen;
    // Start is called before the first frame update
    void Start()
    {
        aud = GameObject.Find("MusicPlayer").GetComponent<AudioMixer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        aud.gameOver = false;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);// loads current scene
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);// loads main menu
    }
    public void TrigEndGameScreen()
    {
        endgamescreen.SetActive(true);
        aud.gameOver = true;

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

