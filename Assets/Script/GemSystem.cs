using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSystem : MonoBehaviour
{
    private GradeSystem gradeSystem;
    public GameObject gemOriginal;
    public Transform gemposition;
	void Update()
	{
        gradeSystem = GameObject.Find("Grade").GetComponent<GradeSystem>();

	}
	void OnCollisionEnter2D(Collision2D fox)
    {
        if (fox.gameObject.tag == "fox")
        {
            gradeSystem.GemNumber++;
            Debug.Log(gradeSystem.GemNumber);
            Destroy(gameObject);
           
        }
    }
}
