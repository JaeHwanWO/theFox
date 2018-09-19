using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallTouch : MonoBehaviour {
    public GameObject heart;
    public GameObject heart3;
    public GameObject heart4;

    public int life = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Fox")
        {
            Debug.Log("life --;");
            heartminus();
        }
    }
    public void heartminus(){
        life--;
        if (life == 2)
        {
            Destroy(heart);
        }
        if (life == 1)
        {
            Destroy(heart3);
        }
        if (life == 0)
        {
            Destroy(heart4);
            SceneLoad(4);

        }
    }
    public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
