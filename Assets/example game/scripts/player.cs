using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
   public string logtext = "I don't understand how people find this is confusing";
   public float speed = 2;
    // Use this for initialization
    void Start () {
        
        Debug.Log(logtext);
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
       
        rigidbody.velocity = Vector2.right * speed;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
