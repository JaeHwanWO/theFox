using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallTouch : MonoBehaviour {
    public int life = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.name == "Fox"){
            //GAMEQUIT!!!!or LIFE NUMBER DECREASESSSS
            Debug.Log("life --;");
            if(life == 3){
                Debug.Log("heart1 destroyed");
                Destroy(heart1);
                Debug.Log("heart1 destroyed");
            }
            if (life == 2)
            {
                Destroy(heart2);
                Debug.Log("heart2 destroyed");

            }
            if (life ==1)
            {
                Destroy(heart3);
                Debug.Log("heart3 destroyed");

            }
            if(life==0){
                Debug.Log("game over");
                SceneLoad(4);
            }
        }
	}

    public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
