using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour{

    private GameManager gameManagerScript;

    private GameObject gameManager;

    public GameObject cactusA;
    public GameObject cactusB;
    public GameObject cactusC;

    public float type;
    public float spawnResetDelay = 2f;
    public float spawnResetDelayOriginal = 1f;

    public bool canSpawn = true;

    void Start(){

        gameManager = GameObject.Find("GameManager");

        gameManagerScript = gameManager.GetComponent<GameManager>();

        spawnResetDelayOriginal = spawnResetDelay;

    }

    void Update(){

        spawnResetDelay = spawnResetDelayOriginal;

        spawnResetDelay -= gameManagerScript.speedMultiplier * Time.deltaTime ;

        spawnResetDelay = Random.Range(spawnResetDelay / 2, spawnResetDelay * 1.5f);

        type = Random.Range(1, 4);

        if(type == 1 && canSpawn){

            Instantiate(cactusA);
            Invoke("SpawnReset", spawnResetDelay);
            canSpawn = false;

        }

        if (type == 2 && canSpawn){

            Instantiate(cactusB);
            Invoke("SpawnReset", spawnResetDelay);
            canSpawn = false;

        }

        if (type == 3 && canSpawn){

            Instantiate(cactusC);
            Invoke("SpawnReset", spawnResetDelay);
            canSpawn = false;

        }

    }

    void SpawnReset(){

        canSpawn = true;

    }

}
