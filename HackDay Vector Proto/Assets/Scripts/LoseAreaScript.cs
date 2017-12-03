using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseAreaScript : MonoBehaviour {

    private Text gameOverText;

	// Use this for initialization
	void Start () {
		gameOverText = GameObject.Find("GameOverText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collider){
        if(collider.name == "PlayerCharacter"){
            Time.timeScale = 0f;
            gameOverText.enabled = true;
        }
    }
}
