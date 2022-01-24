using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour{

    private GameObject player;

    private PlayerDeath playerDeath;

    public float originalSpeed = 0.02f;
    public float speed = 0.1f;
    public float speedMultiplier = 1f;

    public float destroyDelay = 6;

    public bool canDestroy = true;
    public bool canMove = true;

    void Start(){

        Invoke("Destroy", destroyDelay);

        transform.position = new Vector3(15f, -0.803f, 0f);

        player = GameObject.Find("Player");

        playerDeath = player.GetComponent<PlayerDeath>();

    }

    void Update(){

        speed = originalSpeed;

        if (canMove){

            transform.position -= new Vector3(speed * speedMultiplier * Time.deltaTime, 0, 0);

        }

        if (playerDeath.hit){

            canDestroy = false;
            canMove = false;

        }

    }

    void Destroy(){

        if (canDestroy){

            Destroy(gameObject);

        }

    }

}
