using UnityEngine;

public class sequence : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //국어정수와 영어점수로 총점을 구하고 평균을 구하는 프로그램
        int kor = 100;
        int eng = 90;

        int total = 0;
        double avg = 0.0;

        total = kor + eng; // 총점 구하기
        avg = total / 2.0; // 평균 구하기

        Debug.Log($"총점 :  {total}");


        




        Debug.Log($"평균 :  {avg:F1}");    //소수 첫쟤자리까지 출력


      









    }

   /*
   = 제어문 프로그램의 흐름 (순서)를 정하는 명령문
   - 순차문 : 명령이 작성된 순서대로 실행되는 제어문
   - 조건문 : 조건에 맞는 명령문을 실행
   - 반복문 : 정해진 숫자만을 멍령문을 반복해서 실행
   */








    

    // Update is called once per frame
    void Update()
    {
        
    }
}
