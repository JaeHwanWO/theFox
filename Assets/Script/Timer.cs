using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    int frame=0;
    public int second = 0;
    public int clicked = 0;

    public void Clicked()
    {
        clicked = 1;
    }
    // Update is called once per frame
     void Update()
    {
        if (clicked == 1)
        {
            frame++;
            if (frame % 60 == 0)
            {
                second++;
                Debug.Log(second);

            }
        }
        if (SceneManager.GetActiveScene().buildIndex==4){
            PlayerPrefs.SetInt("Secondss", second);
        }
    }

    void Awake()
    {
        
            DontDestroyOnLoad(gameObject);
    }
}
