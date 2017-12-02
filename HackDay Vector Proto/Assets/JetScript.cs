using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetScript : MonoBehaviour {

    [SerializeField] public float activeTime;
    private float jetStart;
    private SpriteRenderer jetImage;
    private BoxCollider2D collider;


	// Use this for initialization
	void Start () {
		jetImage = gameObject.GetComponent<SpriteRenderer>();
        collider = gameObject.GetComponent<BoxCollider2D>();
        jetImage.enabled = false;
        collider.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(jetImage.enabled){
            if(Time.time - jetStart > activeTime){
                Deactivate();
            }
        }
	}

    public void Activate(){
        jetImage.enabled = true;
        collider.enabled = true;
        jetStart = Time.time;
    }

    public void Deactivate(){
        jetImage.enabled = false;
        collider.enabled = false;
    }

    public void JetPosUpdate(float angle){
        Activate();
        transform.rotation = Quaternion.identity;
        transform.Rotate(new Vector3(0f, 0f, angle - 90f));
        transform.localPosition = new Vector3(0f, 0f, 0f);
        transform.localPosition += new Vector3(Mathf.Cos((angle/360f) * Mathf.PI * 2), Mathf.Sin((angle/360f) * Mathf.PI * 2), 0f) * -8f;
    }
}
