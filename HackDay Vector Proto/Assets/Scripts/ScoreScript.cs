using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    private int score;
    private Text scoreText;
    private float timeBetweenScoreIncrease;
    private float lastScoreIncrease;

	// Use this for initialization
	void Start () {
		score = 0;
        scoreText = gameObject.GetComponent<Text>();
        timeBetweenScoreIncrease = .75f;
        lastScoreIncrease = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(lastScoreIncrease - Time.time > timeBetweenScoreIncrease){
            score++;
            lastScoreIncrease = Time.time;
        }
        scoreText.text = "Score: " + score;
	}

    public void AddToScore(int num){
        score += num;
    }
}
