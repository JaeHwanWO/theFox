using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeSystem : MonoBehaviour {
    public int GemNumber=0;
    void Awake(){
        DontDestroyOnLoad(gameObject);
    }
	private void Start()
	{
        int highScore;
        highScore = PlayerPrefs.GetInt("highScore", GemNumber);
        Debug.Log(highScore);
	}
	//게임 끝날때=플레이어 죽을 때 마지막으로 데이터 저장 해주어야 함

	
}
