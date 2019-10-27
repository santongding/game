using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (control.global.player)
        {
            if (control.global.player.transform.position.x > score)
            {
                score = (int)(control.global.player.transform.position.x+0.5);
            }
        }
        this.GetComponent<Text>().text = "score: " + score.ToString();

	}
}
