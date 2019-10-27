using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPoint : Basic_Behaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<player_ball>().isground = 2;
            death();
        }
    }
}
