using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_cube : Basic_Behaviour {
    public bool CanDown;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
         // print(CanDown);
       // print(collision.gameObject.tag== "Player"&&CanDown);
        if (collision.gameObject.tag == "Player" && CanDown)
        {
            //   print("!!!");
            if ((int)collision.contacts[0].normal.x != 0) return;         
            Rigidbody2D tp = this.GetComponent<Rigidbody2D>();
            tp.constraints = ~RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
