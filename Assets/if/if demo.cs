using UnityEngine;

//조건문 : 조건에 맞는 명령문을 실행하는 제어문, if문, switch문이 있다.

public class ifdemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 점수가 60점이상이면 합격을 출력    
        /*
        if(점수가 60점이상)
      
            합격을 출력
     }
    




        */

        int score = 60;

        if (score >= 60)  // 조건식
        {
            //실행문
            Debug.Log("합격");
        }


    }




    /*
    if문
    조건식이 참일떄 실행문을 실행
    조건식이 거짓이면 실해문을 실행하지 않는다

    만약 조건식이 참이면 {}안에 있는 실행문을 실행하라
    if(조건식)
    {
      //실행문1
      //실행문2
     //....
    */
    }



    // Update is called once per frame
 
