using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSystem : MonoBehaviour
{
    public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void LoadFuncTryAgain()
    {
        SceneLoad(0);
    }
    public void LoadFuncMenu()
    {
        SceneLoad(5);
    }
    public void LoadFuncExit()
    {
        //SceneLoad(//게임끝??구현방법모름a);
    }
}
