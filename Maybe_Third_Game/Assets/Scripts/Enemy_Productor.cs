using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Productor : MonoBehaviour {
    private int Tp_Y;
    public void Product(Vector2 Position,int l,int r)
    {
        //print(Position);
        GameObject obj = (GameObject)Instantiate(Resources.Load("enemy\\enemy"));
        obj.GetComponent<Basic_Enemy>().L = l;
        obj.GetComponent<Basic_Enemy>().R = r;
        Position.y += Tp_Y;
        obj.transform.position = Position;
    }
    private void Start()
    {
        GameObject tp = (GameObject)Resources.Load("enemy\\enemy");
        Tp_Y = (int)(tp.transform.localScale.x +0.5);
    }
}