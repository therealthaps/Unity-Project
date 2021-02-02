using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject Panel;

    bool isPaused = false;
    // Update is called once per frame
   public void Settingsmenu()
    {


        if (isPaused && Panel.activeSelf == false)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        if (Panel.activeSelf == false)
        {
            Time.timeScale = 0;
            isPaused = true;
            isPaused = true;
            if (Panel != null)
            {
                Panel.SetActive(true);



            }
        }
    }
}
