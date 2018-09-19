using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsPrint : MonoBehaviour {
    int secondss;

    void Start()
    {
        secondss = PlayerPrefs.GetInt("Secondss",3);
        GetComponent<Text>().text = ":  "+ secondss + " seconds";
    }
}
