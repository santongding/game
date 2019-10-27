using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Behaviour : MonoBehaviour {
    public void death()
    {
      //  print("!!!!!");
        Destroy(this.gameObject);
    }
    public IEnumerator My_Update()
    {
        while (true)
        {
            yield return 0;
            if (control.global.Reback_Point.transform.position.x - this.gameObject.transform.position.x > control.global.died_dis)
            {
                death();
            }
            if (this.gameObject.transform.position.y < control.global.Get_Map.GetComponent<Map_Productor>().Last_Height - control.global.died_dis)
            {
             //   print("JUMP");
                death();
            }
        }
    }
    void Awake(){
        StartCoroutine(My_Update());
    }
}
