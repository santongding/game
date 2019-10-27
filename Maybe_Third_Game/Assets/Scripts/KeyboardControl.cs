using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour {
    public Dictionary<KeyCode, bool> GetKeyDown;
    public Dictionary<KeyCode, bool> GetKey;
	// Use this for initialization
	void Start () {
        GetKeyDown = new Dictionary<KeyCode, bool>();
        GetKey = new Dictionary<KeyCode, bool>();
	}
	
	// Update is called once per frame
	void Update () {

        for(int i = (int)KeyCode.A; i <=(int) KeyCode.W; i++)
        {
            if (Input.GetKeyDown((KeyCode)i)){
                GetKeyDown[(KeyCode)i]=true;
            }
            if (Input.GetKey((KeyCode)i))
            {
                GetKey[(KeyCode)i]=true;
            }
        }
	}
}
