using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
   public string logtext = "I don't understand how people find this is confusing";
   public float speed = 2;
    public float health = 10;
    public float jumpspeed = 50;
    // Use this for initialization
    void Start () {
        
        Debug.Log(logtext);
        //apply_damage(1);
    }
	
	// Update is called once per frame
	void Update () {
       
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

       
        // number between -1 and 1 based on player pressing left or right
        float horizontal = Input.GetAxis("Horizontal");

        bool jump = Input.GetButtonDown("Jump");

        Collider2D collider =GetComponent<Collider2D>();
        LayerMask groundlayer = LayerMask.GetMask("Ground");
        bool touchingGround = collider.IsTouchingLayers(groundlayer);

        Debug.Log(horizontal);

        Vector2 velocity = rigidbody.velocity;
        velocity.x = horizontal *speed;
        if (jump==true && touchingGround==true)
        {
            velocity.y = jumpspeed;
        }
        rigidbody.velocity = velocity;
        if (Input.GetMouseButton(0))
        {
            Debug.Log(" mouse button down!");
        }

        Vector2 mouseposition = Input.mousePosition;
        Debug.Log("Mouse position is" + mouseposition);
    }
   public void apply_damage(float damage)
    {
        health = health - damage;
     
 }  
}
