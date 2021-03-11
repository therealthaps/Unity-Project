using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    
    int count = 0;

 
 
public static KeyCode SpacebarKey()
    {
        if (Application.isEditor) return KeyCode.O;
        else return KeyCode.Space;
    }
    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            panel1.SetActive(false);
        }
         if (panel1.activeSelf == false && count == 0){
            panel2.SetActive(true);
            count++;
        }

        if (Input.GetKeyDown(SpacebarKey()) && count == 1)
        {
            Debug.Log("SpacePressed");
            panel2.SetActive(false);
        }
        

    }
}
