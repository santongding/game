using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Productor : MonoBehaviour {
    private int Max_R=-100;
    public int Last_Height=0;
    public int Max_Height = 0;
    public int HardLevel;
    private GameObject PRC;
    void Born_It()
    {
        int Tp_H = Random.Range(Last_Height - 10, Last_Height + 11);
        int X_Num = Random.Range(1, HardLevel+1);
        bool Can_Enemy = Random.Range(1, 3)==1;
        bool CanDown = Random.Range(1, 4) == 1;
    //    X_Num = 1;
     //   print(Can_Enemy);
        // int Space_Num = Random.Range(0, 4);
        int L=0, R=0;
        GameObject obj=PRC;
        for (int i = 1; i <= X_Num; i++)
        {
              obj = Instantiate((GameObject)Resources.Load("wall\\wall"));
            //   print(obj.transform.localScale);
            if (i == 1)
            {
                Max_R += Random.Range(0, 4) * (int)(obj.transform.localScale.x + 0.5);
                L = Max_R;
            }
            obj.transform.position = new Vector2(Max_R, Tp_H);
            obj.GetComponent<wall_cube>().CanDown = CanDown;
                if (i == X_Num) R = Max_R;
            Max_R += (int)(obj.transform.localScale.x+0.5);
           
        }
        //Add jump point
        if (X_Num == 1 && (Can_Enemy == false) && Random.Range(1, 3) == 1)
        {
            GameObject tp = Instantiate((GameObject)Resources.Load("JumpPoint\\JumpPoint"));
            tp.transform.position = obj.transform.position;
            obj.GetComponent<wall_cube>().death();
            
        }
        //
        if (Can_Enemy)
        {
            PRC.GetComponent<Enemy_Productor>().Product(new Vector2(L, Tp_H), L, R);
        }
        Last_Height = Tp_H;
        if (Max_Height < Last_Height) Max_Height = Last_Height;
    }
	// Use this for initialization
	void Start () {
        //      print("PRODUCTOR");
        HardLevel = control.global.HardLevel;
        PRC = (GameObject)Instantiate( Resources.Load("Product\\Enemy_PRC"));
    }
	
	// Update is called once per frame
	void Update () {
      //  print("PRODUCTOR");
        while (Max_R - control.global.camera.transform.position.x < 100)
        {
            Born_It();
        }
	}
}
