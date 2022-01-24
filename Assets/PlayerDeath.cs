using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour{

    public GameObject ground;
    public GameObject stones;
    public GameObject clouds;

    public GameObject deathScreen;

    public GameObject dieSpeaker;

    public GameObject dieSprite;

    public bool hit = false;

    public bool hasPlayed = false;

    void OnTriggerEnter2D(Collider2D collision){

        if(collision.tag == "Cactus"){

            hit = true;

        }
        
    }

    void Start(){


        
    }

    void Update(){

        if (hit){

            if(hasPlayed == false){

                dieSpeaker.GetComponent<AudioSource>().Play();

                dieSprite.transform.position = gameObject.transform.position;

                gameObject.transform.position = new Vector3(500f, 500f, 0f);

                hasPlayed = true;

            }

            gameObject.GetComponent<Player>().canJump = false;
            ground.GetComponent<Ground>().originalSpeed = 0f;
            ground.GetComponent<Ground>().speed = 0f;
            stones.GetComponent<StoneMovement>().speed = 0f;
            clouds.GetComponent<SkyMovement>().speed = 0f;

            deathScreen.SetActive(true);

        }
        
    }

}
