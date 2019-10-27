using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Blood : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
        this.GetComponent<Slider>().value = control.global.blood;
        this.GetComponent<Slider>().maxValue = control.global.Max_blood;

    }
}
