using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_ball : MonoBehaviour {
    public int isground = 0;
    public int can_move = 0;
    public int X_Speed = 20 ;
    public int Y_Speed = 40;
    public int SpeedUp = 20;
    //private GameObject Cobj;
    // Use this for initialization
    void DEAD_TEXT()
    {
        Instantiate((GameObject)Resources.Load("Death_Text"));
    }
    public  void death()
    {
        control.global.blood-- ;
   //     print(control.global.blood);
        if (control.global.blood <0)
        {
          //  print("DEATH");
        //    print("!!!");
            Instantiate((GameObject)Resources.Load("Death_Text"));
            // this.Invoke("DEAD_TEXT", 1);
            //  Instantiate((GameObject) Resources.Load("Death_Text"));
        }
        Destroy(this.gameObject);
    }
	void Start () {
        //   this.gameObject.GetComponent<BoxCollider2D>().friction = 0;
        can_move = 0;
        isground = 1;
        this.GetComponent<Animator>().SetInteger("IsGround", isground);
	}
	
	void Update () {
        Vector2 tp = GetComponent<Rigidbody2D>().velocity;
        Vector3 TpAngles = GetComponent<Transform>().eulerAngles;
        int Tp_Speed = X_Speed;
        if (Mathf.Abs(tp.x) > X_Speed * 0.5 && (control.global.kbc.GetKeyDown.ContainsKey(KeyCode.A) || control.global.kbc.GetKeyDown.ContainsKey(KeyCode.D))) Tp_Speed =X_Speed +SpeedUp ;
        if (Mathf.Abs(tp.x) > X_Speed) Tp_Speed = X_Speed + SpeedUp;
        if ((control.global.Reback_Point.transform.position.x - this.transform.position.x)*2 > control.global.died_dis) can_move = 1;
        if (this.gameObject.transform.position.y < control.global.Get_Map.GetComponent<Map_Productor>().Last_Height - control.global.died_dis) death();
        if (can_move <= 0 && control.global.kbc.GetKey.ContainsKey(KeyCode.A))
        {
            tp.x = -Tp_Speed;
            TpAngles.y = 180f;
        }
        else if (can_move >= 0 && control.global.kbc.GetKey.ContainsKey(KeyCode.D))
        {
            tp.x = Tp_Speed;
            TpAngles.y = 0f;
        }
        else tp.x *= 0.95f;
        GetComponent<Transform>().eulerAngles = TpAngles;
        if (isground > 0 && control.global.kbc.GetKeyDown.ContainsKey(KeyCode.W))
        {
            if (tp.y < 0) tp.y = Y_Speed;
            else
            tp.y+= Y_Speed;
            isground--;

            this.GetComponent<Animator>().SetInteger("IsGround", isground);
            this.GetComponent<Animator>().SetTrigger("CanJump");

        }
            GetComponent<Rigidbody2D>().velocity=tp;
       // print(tp);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject == false) return;
        if (collision.gameObject.tag == "ground" && (int)(Mathf.Abs(collision.contacts[0].normal.x) + 0.5) == 0)
        {
            isground = 2;
            this.GetComponent<Animator>().SetInteger("IsGround", isground);
        }

    }
}
