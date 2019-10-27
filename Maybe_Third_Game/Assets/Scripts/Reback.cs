using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reback : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(control.global.blood > 0)
        {

            if (control.global.kbc.GetKeyDown.ContainsKey(KeyCode.R))
            {
                if (control.global.player == false)
                {
                    control.global.player = (GameObject)Instantiate(Resources.Load("player\\player"));
                }
                else
                {
                    control.global.blood--;
                }
                control.global.player.transform.position = this.transform.position;
                control.global.player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
            if (control.global.kbc.GetKeyDown.ContainsKey(KeyCode.S) && control.global.player && control.global.player.GetComponent<player_ball>().isground==2 &&control.global.player.GetComponent<player_ball>().transform.position.x>this.transform.position.x)  
            {
                control.global.blood--;
                this.transform.position = control.global.player.transform.position;
            }
        }else if (control.global.player == false)
        {
            if (control.global.kbc.GetKeyDown.ContainsKey(KeyCode.R))
            {
                if (control.global.blood==0)
                {
                    control.global.player = (GameObject)Instantiate(Resources.Load("player\\player"));
                    control.global.player.transform.position = this.transform.position;
                    control.global.player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                }
                else
                {
                    print("RELOAD");
                    UnityEngine.SceneManagement.SceneManager.LoadScene("first_scene");
                }
            }
        }
    }
}
