using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour {
    public void buttonnn()
	{
        Debug.Log("3초 이따 씬 전환");
        Invoke("SceneLoad", 2f);
	}
    public void SceneLoad()
    {
        SceneManager.LoadScene(1);
    }
    public void SceneLoad2(int number){
        SceneManager.LoadScene(number);
    }
}
