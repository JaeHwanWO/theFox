using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlippingFox : MonoBehaviour {

    void slip(){
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
