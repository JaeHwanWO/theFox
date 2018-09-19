using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour {
    
    public InputField inputField;
    public string playerid;
    public GameObject log;

    public void EnterId(){
        playerid = inputField.text;
        Debug.Log(playerid);
        PlayerPrefs.SetString("playerid", playerid);
        if (playerid != null){
            log.SetActive(false);
        }
    }
}
