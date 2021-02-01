using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed= 0.1f;
    private int damage = 100;
    public GameObject deathEffect;

    // Start is called before the first frame update
    void Start()
    {
        float randomX = Random.Range(-7.79f, 2.16f);
        transform.position= new Vector3(randomX,4.28f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0) 
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

            if (transform.position.y < -3.0f) {
                float randomX = Random.Range(-7.79f, 2.16f);
                transform.position = new Vector3(randomX, 2.5f, 0);
            }

        }


        private void OnTriggerEnter2D(Collider2D other) {


            if (other.tag == "bullet") {
                Destroy(other.gameObject);
                Debug.Log("Hit2");
            damage -= 50;
            if (damage <= 0)
            {
                Die();
            }
            }
            if (other.tag == "PLayer") {
                GameControlScript.health -= 1;
                Debug.Log("Hit1");

            Destroy(this.gameObject);

                Player_sprite player = other.transform.GetComponent<Player_sprite>();
                if (player != null) {

                    player.Damage();
                }


            }


        }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

}
