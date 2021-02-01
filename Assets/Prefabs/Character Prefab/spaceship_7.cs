using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship_7 : MonoBehaviour
{
    [SerializeField]// to control value through the inspector
    private float speed = 7f;
    public float horizontalInput;
    public float verticalInput;
    
    [SerializeField]
    private float _fire = 0.25f;
    private float _canfire = -1f;
    [SerializeField]
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void CalculateMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(verticalInput, horizontalInput, 0) * speed * Time.deltaTime);

        // if player position on y is greater than 0
        //y position=0
        // else if position on y is less than -3.8f
        if (transform.position.y >= 4.28f)
        {
            transform.position = new Vector3(transform.position.x, 1.0f, 0);
        }
        else if (transform.position.y <= -3.81f)
        {
            transform.position = new Vector3(transform.position.x, -2.5f, 0);
        }

        if (transform.position.x <= -7.79f)
        {
            transform.position = new Vector3(-7.79f, transform.position.y, 0);
        }
        else if (transform.position.x >= 2.16f)
        {
            transform.position = new Vector3(2.15f, transform.position.y, 0);
        }
    }

    public void Damage()
    {
        lives -= 1;
        if (lives < 1)
        {
            Destroy(this.gameObject);
        }
    }

}
