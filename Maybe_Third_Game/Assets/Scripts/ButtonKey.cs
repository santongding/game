using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonKey : MonoBehaviour {
    // Use this for initialization
    public char S;
    bool OnPressed;
	void Start () {
    //    Transform[] child = GetComponentsInChildren<Transform>();
        S = GetComponentInChildren<Text>().text[0];
        OnPressed = false;
    }
	// Update is called once per frame
	void Update () {
        if (OnPressed && control.global)
        {
            Debug.Log(KeyCode.A + S - 'A');
            control.global.kbc.GetKey[KeyCode.A + S - 'A'] = true;
        }
	}
    public void PointDown()
    {
    //   Debug.Log("POINTDOWN");
        if (control.global)
        {
            control.global.kbc.GetKeyDown[KeyCode.A + S -'A']= true;
        }
        OnPressed = true;
    }
    public void PointUp()
    {
        OnPressed = false;
    }
}
