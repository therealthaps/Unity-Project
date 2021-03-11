using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_to_shoot : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
    }

}
