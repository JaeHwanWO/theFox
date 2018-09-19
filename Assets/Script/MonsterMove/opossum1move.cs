using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opossum1move: MonoBehaviour {
    
    int a = 1;

    void Update(){ 
        
  if (transform.localPosition.x < -0.7f){
    a = -1; 
            //
  } 
  else if(transform.localPosition.x  > 8f) 
  { 
    a = 1; 
  } 
      transform.Translate(Vector3.left * 3*  Time.deltaTime * a); 
 }

    public void Opossum(){
        if (a == -1)
        {
            GetComponent<Animator>().SetInteger("opossumint", 0);
        }
        else if (a==1){
            GetComponent<Animator>().SetInteger("opossumint", 1);
        }
   //어디 수정해야되는지 모르겠다ㅜㅜ

    }

} 
