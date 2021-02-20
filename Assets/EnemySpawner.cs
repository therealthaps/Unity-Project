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
            Vector3 postToSpawn = new Vector3(Random.Range(-9.1f, 2.1f), 4.1f, 0);
            Instantiate(EnemyPrefab, postToSpawn, Quaternion.identity);

            yield return new WaitForSeconds(2.0f);


        }
        
    }
    public void OnPlayerDeath()
    {
        stopSpawning = true;
    }
}
    


