using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialA : MonoBehaviour
{
    public GameObject panel1;
    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            panel1.SetActive(false);
        }
    }
}