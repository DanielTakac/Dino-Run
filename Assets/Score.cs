using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour{

    public GameObject player;

    public Text HighscoreText;
    public Text ScoreText;
    
    public float score = 0f;

    public int highscore;

    public int scoreFinal;

    void Start(){



    }

    void Update(){

        HighscoreText.text = highscore.ToString("D4");
        ScoreText.text = scoreFinal.ToString("D4");

        highscore = PlayerPrefs.GetInt("highscore");

        if(player.GetComponent<PlayerDeath>().hit == false){

            score += Time.deltaTime * 4.6f;

        }

        scoreFinal = (int)score;

        if (scoreFinal > highscore){

            PlayerPrefs.SetInt("highscore", scoreFinal);

            Debug.Log("Saving highscore");

        }

        if (Input.GetKeyDown("j")){

            ResetHighscore();

        }

    }

    void ResetHighscore(){

        highscore = 0;

        PlayerPrefs.SetInt("highscore", highscore);

    }

}
