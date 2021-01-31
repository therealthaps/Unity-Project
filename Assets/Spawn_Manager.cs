using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;
    
    
    private bool stopSpawning= false;
   
// Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator SpawnRoutine(){
        
        while(stopSpawning == false){
            Vector3 postToSpawn = new Vector3(Random.Range(-3f, 3f),2.5f,0);
            Instantiate(EnemyPrefab,postToSpawn,Quaternion.identity);
            
            yield return new WaitForSeconds(5.0f);
        

    }
        // we will never reach here
}
    public void OnPlayerDeath(){
        stopSpawning= true; 
    }
}
