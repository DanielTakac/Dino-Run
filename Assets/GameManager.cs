using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public float timeElapsed = 0f;

    public float speedMultiplier = 1f;

    public float speedMultiplierOriginal = 100f;

    public float gameSpeedMultiplier = 1f;

    public float slower = 0.01f;

    void Start(){

        timeElapsed = 0f;

    }

    void Update(){

        timeElapsed += Time.deltaTime;

        speedMultiplier += Time.deltaTime * slower * speedMultiplierOriginal;

        if (Input.GetKeyDown("r")){

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            Debug.Log("Restart");

        }

    }

}
