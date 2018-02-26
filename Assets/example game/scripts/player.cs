using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
   public string logtext = "I don't understand how people find this is confusing";
   public float speed = 2;
    public float health = 10;
    // Use this for initialization
    void Start () {
        
        Debug.Log(logtext);
        //apply_damage(1);
    }
	
	// Update is called once per frame
	void Update () {
       
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = Vector2.right * speed;

    }
   public void apply_damage(float damage)
    {
        health = health - damage;
     
 }  
}
