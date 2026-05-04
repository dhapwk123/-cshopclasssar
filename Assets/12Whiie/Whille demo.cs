using UnityEngine;

public class Whilledemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //안녕하세요 3번 출력하는 프로그램 구현
        //for(초기식;조건식;증감식)
        for (int i = 0; i < 3; i++)
        {
            //반복 실행문 - 안녕하세요 출력
            Debug.Log("안녕하세요");
        */
          
        //초기식
        int i = 0;

        while (i < 3) ;    //조건식
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //증감식     
            i++; //1 -> 2 -> 3
        }
    

        }
}
    /*
   == while
   while(조건식)
    {
        //반복 실행문 
    }
    조건식 판별(참)  -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행 -> 조건식 판별(거짓) -> while 종료

    //조건식이 참(true)이면 반복문을 실행하고 
    //조건식이 거짓(false)이면 while운을 종료한다
    
     */