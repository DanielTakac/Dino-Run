using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public GameObject jumpSpeaker;
    public GameObject landSpeaker;
    public GameObject gameManager;

    public float jumpForce = 5f;
    public float resetDelay = 0.5f;

    public bool canReset = true;
    public bool canJump = true;
    public bool isGrounded = true;

    void OnCollisionEnter2D(Collision2D collision){

        isGrounded = true;

        landSpeaker.GetComponent<AudioSource>().Play();

    }

    void OnCollisionExit2D(Collision2D collision){

        isGrounded = false;

    }

    void Start(){

        canJump = true;
        
    }

    void Update(){

        if (Input.GetKey("space") && canJump && isGrounded){

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));

            jumpSpeaker.GetComponent<AudioSource>().Play();

            Invoke("JumpReset", resetDelay);

            Debug.Log("Jump");

            canReset = false;
            canJump = false;

        }

        if (canReset){

            canJump = true;

        }

    }

    void JumpReset(){

        canReset = true;

    }

}
