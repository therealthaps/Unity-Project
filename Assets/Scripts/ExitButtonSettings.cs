using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonSettings : MonoBehaviour
{
    public GameObject Panel;
    bool isPaused = false;
    // Start is called before the first frame update
    public void ExitSettings()
    {

        if (Panel != null)
        {
            Panel.SetActive(false);

            Time.timeScale = 1;
            isPaused = false;

        }

    }
}
