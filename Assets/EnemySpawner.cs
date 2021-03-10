using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject EnemyPrefab;
  


    private bool stopSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnRoutine()
    {

        while (stopSpawning == false)
        {
            Vector3 postToSpawn = new Vector3(Random.Range(-2.8f, 9.0f), 4.0f, 0);
            Instantiate(EnemyPrefab, postToSpawn, Quaternion.identity);

            yield return new WaitForSeconds(3.0f);


        }
        
    }
    public void OnPlayerDeath()
    {
        stopSpawning = true;
    }
}
    


