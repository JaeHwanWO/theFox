using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepHeart : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
