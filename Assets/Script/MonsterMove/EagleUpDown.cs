using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleUpDown : MonoBehaviour {
    int a = 1;
        void Update()
        {

        if (transform.localPosition.y < 2f)
        {
            a = -1;
            //
        }
            else if (transform.localPosition.y > 3.5f)
            {
                a = 1;
            }
            transform.Translate(Vector3.down * 2 * Time.deltaTime * a);
       }
}

