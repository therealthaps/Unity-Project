using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject Heart, Heart1, Heart2;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Heart.gameObject.SetActive(true);
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                Heart.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                break;

            case 2:

                Heart.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                break;
            case 1:

                Heart.gameObject.SetActive(true);
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                break;
            case 0:

                Heart.gameObject.SetActive(false);
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Time.timeScale = 0;
                break;
        }
    }
}
