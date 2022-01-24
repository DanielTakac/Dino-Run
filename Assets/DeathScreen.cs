using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathScreen : MonoBehaviour{

    public GameObject buttonUp;
    public GameObject buttonDown;

    public GameObject buttonSpeaker;

    public bool isPressed = false;

    void Start(){


        
    }

    void Update(){

        if (Input.GetKeyDown("space")){

            PressButton();

        }
        
    }

    public void PressButton(){

        buttonSpeaker.GetComponent<AudioSource>().Play();

        buttonDown.SetActive(true);
        buttonUp.SetActive(false);

        Invoke("ButtonUp", 0.3f);

        Invoke("Restart", 1f);

    }

    public void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void ButtonUp(){

        buttonDown.SetActive(false);
        buttonUp.SetActive(true);

    }

}
