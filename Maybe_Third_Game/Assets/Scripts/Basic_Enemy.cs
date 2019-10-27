using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Enemy : Basic_Behaviour {
    public int L, R;
    private int Speed_Location = 1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (L != R)
        {
            if (this.transform.position.x <= L) Speed_Location = 1;
            if (this.transform.position.x >= R) Speed_Location = -1;
            this.GetComponent<Rigidbody2D>().velocity =new Vector2(10 * Speed_Location, this.GetComponent<Rigidbody2D>().velocity.y);
        }

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
     //   print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            if ((int)(Mathf.Abs(collision.contacts[0].normal.x) + 0.5) == 0)
            {
                this.GetComponent<Animator>().SetTrigger("EnemyDie");
                if(control.global.blood<control.global.Max_blood)
                control.global.blood++;
                control.global.player.GetComponent<player_ball>().isground = 2;
                control.global.player.GetComponent<Animator>().SetInteger("IsGround",2);
                this.tag = "Untagged";
            }
            else
            {
                collision.gameObject.GetComponent<player_ball>().death();
            }
        }
    }
}
