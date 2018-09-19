using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : MonoBehaviour {
    int touch = 0;
    private FallTouch script;
	// Update is called once per frame
    void Update () {
        
        script = GameObject.Find("BottomWall").GetComponent<FallTouch>();


        GetComponent<Animator>().SetInteger("TotalFoxControl_i",0);


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
            GetComponent<Animator>().SetInteger("TotalFoxControl_i",1);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
            GetComponent<Animator>().SetInteger("TotalFoxControl_i",6);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            touch++;
            if (touch < 3)
            {
                transform.Translate(0f, 1f, 0f);
                GetComponent<Animator>().SetInteger("TotalFoxControl_i", 3);
                //투터치 제한 만들기a
            }

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            touch++;
            if (touch < 3)
            {
                transform.Translate(0f, 1f, 0f);
                GetComponent<Animator>().SetInteger("TotalFoxControl_i", 3);
            }
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        touch = 0;

        if (collision.gameObject.tag == "monster")
        {
            Debug.Log("mostertouch;");
            //다른 스크립트의 함수 호출
            script.heartminus();
        }
    }
}
