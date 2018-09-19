using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSystem : MonoBehaviour {

    public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag =="fox"){
            SceneLoad(2);
            
        }
	}
}
