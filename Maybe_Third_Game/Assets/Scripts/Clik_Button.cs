using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clik_Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	public void click () {
   //     print("!!!");
        Instantiate(Resources.Load("central"));
        control.global.HardLevel = (int)(GameObject.Find("Slider").GetComponent<Slider>().value+0.5);
        Destroy(this.gameObject);
    }
}
