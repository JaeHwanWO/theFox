using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepWall : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
