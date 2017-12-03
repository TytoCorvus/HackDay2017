using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    [SerializeField] public float spawnInterval;
    [SerializeField] public GameObject enemy;
    private float lastSpawnTime = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - lastSpawnTime > spawnInterval){
            Spawn();
            lastSpawnTime = Time.time;
        }
	}

    public void Spawn(){

    }
}
