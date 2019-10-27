using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    public static control global;
    public int died_dis =100;
    public new GameObject camera;
    public GameObject player;
    public int blood,Max_blood;
    public GameObject Get_Map;
    public GameObject Reback_Point;
    public GameObject KeyboardController;
    public KeyboardControl kbc;
    public int HardLevel;
    private void init()
    {
        blood = 1;
        Max_blood = 10;
        KeyboardController = Instantiate((GameObject) Resources.Load("Prefab\\KeyboardController"));
        kbc = KeyboardController.GetComponent<KeyboardControl>();
        Instantiate((GameObject)Resources.Load("player\\Show_Object"));
        Get_Map=Instantiate((GameObject)Resources.Load("Product\\Get_Map"));
        GameObject obj =Instantiate((GameObject)Resources.Load("player\\player"));
        obj.transform.position = new Vector2(0, 50);
        GameObject tp=Instantiate((GameObject)Resources.Load("player\\Reback_Point"));
        Reback_Point = tp;
        tp.transform.position = obj.transform.position;
        player = obj;
        camera = GameObject.Find("Main Camera");
    }
    private void Awake()
    {
        init();
        global = this;
    }
    // Use this for initialization
    void Start () {
      //  print(global.camera.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        kbc.GetKeyDown.Clear();
        kbc.GetKey.Clear();
	}
}
