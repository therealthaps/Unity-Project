using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public GameObject endgamescreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);// loads current scene
    }
    public void TrigEndGameScreen()
    {
        endgamescreen.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
