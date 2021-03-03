using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject Heart1, Heart2, Heart3,FadedHeart,FadedHeart2,FadedHeart3;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        FadedHeart.gameObject.SetActive(false);
        FadedHeart2.gameObject.SetActive(false);
        FadedHeart3.gameObject.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                break;

            case 2:

                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                FadedHeart.gameObject.SetActive(true);
                break;
            case 1:

                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(true);
                FadedHeart.gameObject.SetActive(true);
                FadedHeart2.gameObject.SetActive(true);
                break;
            case 0:

                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                FadedHeart.gameObject.SetActive(true);
                FadedHeart2.gameObject.SetActive(true);
                FadedHeart3.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}
