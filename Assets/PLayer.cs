using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    [SerializeField]// to control value through the inspector
    private float speed= 7f;
    public float horizontalInput;
    public float verticalInput;
    [SerializeField]
    private GameObject laserPrefab;
    [SerializeField]
    private float _fire= 0.25f;
    private float _canfire= -1f;
    [SerializeField]
    private int lives= 4;
    private Spawn_Manager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        transform.position= new Vector3(0,0,0);
        spawnManager= GameObject.Find("Spawn_Manager").GetComponent<Spawn_Manager>();
        if(spawnManager==null){
            Debug.LogError("The Spawn Manager is NULL");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > _canfire){
            _canfire= Time.time + _fire;
            Instantiate(laserPrefab, new Vector3(transform.position.x, transform.position.y+0.5f, 0), Quaternion.identity/* default rotation */);
        }
        
    }
    void CalculateMovement(){
        float verticalInput= Input.GetAxis("Vertical");
        float horizontalInput= Input.GetAxis("Horizontal");
        
        transform.Translate(new Vector3(horizontalInput, verticalInput,0) * speed * Time.deltaTime);
        
        // if player position on y is greater than 0
        //y position=0
        // else if position on y is less than -3.8f
        if(transform.position.y >=2.5f){
            transform.position= new Vector3(transform.position.x,2.5f,0);
        }
        else if(transform.position.y  <= -2.5f ){
            transform.position= new Vector3(transform.position.x, -2.5f, 0);
        }
        
        if(transform.position.x <= -3.54f ){
            transform.position = new Vector3(-3.54f, transform.position.y,0);
        }
        else if( transform.position.x>= 3.54f){
            transform.position= new Vector3( 3.54f, transform.position.y, 0);
        }
    }
    
    public void Damage(){
        lives-=1;
        if(lives<1){
            // find game object and get component
            spawnManager.OnPlayerDeath();
            Destroy(this.gameObject);
        }
    }
 
}
