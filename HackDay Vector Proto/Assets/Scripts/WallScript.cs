using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallScript : MonoBehaviour {

    [SerializeField] public Vector3 throwDirection;
    [SerializeField] public float throwForce;
    private ScoreScript scoreScript;


	// Use this for initialization
	void Start () {
		scoreScript = GameObject.Find("ScoreText").GetComponent<ScoreScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collider){
        if(collider.name == "PlayerCharacter"){
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = throwDirection * throwForce;
        }
        if(collider.tag == "Enemy"){
            Destroy(collider.gameObject, 0f);
            scoreScript.AddToScore(10);
        }
    }
}
