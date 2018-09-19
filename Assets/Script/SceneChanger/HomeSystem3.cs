using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSystem3 : MonoBehaviour
{

    public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(4);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fox")
        {
            SceneLoad(4);
        }
    }
}
