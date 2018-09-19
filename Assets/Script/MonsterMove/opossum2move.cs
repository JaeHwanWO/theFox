using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opossum2move : MonoBehaviour
{

    int a = 1;

    void Update()
    {

        if (transform.localPosition.x < 0.5f)
        {
            a = -1;
        }
        else if (transform.localPosition.x > 5.9f)
        {
            a = 1;
        }
        transform.Translate(Vector3.left * 5 * Time.deltaTime * a);
    }
}
