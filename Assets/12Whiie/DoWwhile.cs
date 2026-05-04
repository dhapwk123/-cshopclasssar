using UnityEngine;

public class DoWwhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*  
         //초기식
              int i = 0;

              while (i < 3) ;    //조건식
              {
                  //반복 실행문
                  Debug.Log("안녕하세요");

                  //증감식     
                  i++; //1 -> 2 -> 3
              }*/

        // [1] 초기식
        int i = 0;
        do
        {
            // 반복 실행문
            Debug.Log("안녕하세요");

            // [2]증감식
            i++;
        } while (i < 3);
    }
}
/*  
 //초기식
      int i = 0;

      while (i < 3) ;    //조건식
      {
          //반복 실행문
          Debug.Log("안녕하세요");

          //증감식     
          i++; //1 -> 2 -> 3
      }*/   //[1] 초기식
       
        


/*
 ==do while
do
{
    //반복 실행문    
   
}while(조건식)

//무조건 먼저 반복 실행문을 실행한다
//조건식이 참(true)이면 반복문을 실행하고
//조건식이 거짓(false)이면 while문을 중료한다

*/