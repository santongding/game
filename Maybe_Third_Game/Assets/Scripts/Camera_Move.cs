using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour {
   // public GameObject player;
    private Vector2 Move_Speed=new Vector3(0.03f,0.10f);
	// Use this for initialization
	void Start () {
       // player = GameObject.Find("Player");

    }
	
	// Update is called once per frame
	void Update () {
        if (control.global&&control.global.player)
        {
            Vector3 tp= gameObject.transform.position -control.global.player.transform.position;
            tp.x *= Move_Speed.x;
            tp.y *= Move_Speed.y;
            tp.z = 0;
            gameObject.transform.position = gameObject.transform.position - tp;
            }
      //  gameObject.transform.position=new Vector3 ((gameObject.transform.position.x - player.transform.position.x) * (1-Move_Speed.x), (gameObject.transform.position.y - player.transform.position.y) *(1- Move_Speed.y),gameObject.transform.position.z);
	}
}
