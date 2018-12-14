using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movement;
    public float jumping;
    public bool groundCheck;
    public LayerMask myGround;

    private Collider2D myCol;
    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {

        rigid = GetComponent<Rigidbody2D>();

        myCol = GetComponent<Collider2D>();

		    
	}
	
	// Update is called once per frame
	void Update () {
        groundCheck = Physics2D.IsTouchingLayers(myCol, myGround);
        rigid.velocity = new Vector2(movement, rigid.velocity.y);

        if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (groundCheck)
            {
                rigid.velocity = new Vector2 (rigid.velocity.x, jumping);
            }
        }
		
        
	}
}
