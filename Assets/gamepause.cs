using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamepause : MonoBehaviour
{
    bool isPaused =false;
    // Start is called before the first frame update
    public void pauseGame(){
if(isPaused){

    Time.timeScale=1;
    isPaused =false;
}

    else{
Time.timeScale=0;
isPaused=true;
    }


    }
}
