using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGemNumber : MonoBehaviour {
    
    private GradeSystem gradeSystem;
     void Update()
    {
        gradeSystem = GameObject.Find("Grade").GetComponent<GradeSystem>();
        GetComponent<Text>().text = "GemNumber : " + gradeSystem.GemNumber;
    }

}
