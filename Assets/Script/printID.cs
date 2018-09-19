using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printID : MonoBehaviour {
    
    public string playerId;

    public void Print(){
        playerId = PlayerPrefs.GetString("playerid");
        Debug.Log(playerId);
        GetComponent<Text>().text = "id: "+ playerId;
    }
}
