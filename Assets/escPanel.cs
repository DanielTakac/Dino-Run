using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escPanel : MonoBehaviour{

    public GameObject escapeText;

    public float resetDelay = 3;

    public bool escapePressed = false;

    void Start(){

		escapePressed = false;
        
    }

    void Update(){

		if(Input.GetKeyDown("escape")){
	    
	    	if(escapePressed){
		
				Application.Quit();
		
	    	} else {
	    
    	    	escapePressed = true;

	    		Debug.Log("Escape Pressed");

	    		escapeText.SetActive(true);

	    		Invoke("ResetEscape", resetDelay);

	    	}
	
		}
        
    }

    public void ResetEscape(){
	
		escapePressed = false;

		escapeText.SetActive(false);
	
    }

}
