using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamepause : MonoBehaviour
{
    public GameObject Panel;
    bool isPaused = false;
    // Start is called before the first frame update
    public void pauseGame()
    {
        if (isPaused && Panel.activeSelf == false)
        {

            Time.timeScale = 1;
            isPaused = false;
        }

        if(Panel.activeSelf==false)
        {
            Time.timeScale = 0;
            isPaused = true;
            if (Panel != null)
            {
                Panel.SetActive(true);



            }
        }

        
            

    }
}

