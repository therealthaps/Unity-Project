using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_sprite: MonoBehaviour
{
    [SerializeField]// to control value through the inspector
    private float speed = 7f;
    public float horizontalInput;
    private AudioSource[] soundfx;
    private SpriteRenderer player;
    private RestartScript restart;
    
    
    [SerializeField]
    private int lives = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        soundfx = GetComponents<AudioSource>();
        player = GetComponent<SpriteRenderer>();
        restart = GameObject.Find("RestartObject").GetComponent<RestartScript>();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        

    }
    void CalculateMovement()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput, 0, 0) * Time.deltaTime * speed;

        
        // if player position on y is greater than 0
        //y position=0
        // else if position on y is less than -3.0f
        

        if (transform.position.x <= -2.8f)
        {
            transform.position = new Vector3(-2.8f, transform.position.y, 0);
        }
        else if (transform.position.x >= 9.0f)
        {
            transform.position = new Vector3(9.0f, transform.position.y, 0);
        }
    }

    public void Damage()
    {
        lives -= 1;
        if (lives < 1)
        {
            soundfx[2].Play();
            Destroy(player);
            restart.TrigEndGameScreen();
        }
        soundfx[1].Play();
    }

}
