using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float speed= 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(0,1,0)* speed * Time.deltaTime);
        if(transform.position.y >=5){
            Destroy(this.gameObject);
        }
    }
}
