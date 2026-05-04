using System;
using UnityEngine;

public class Forsim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 20까지 합을 구하는 프로그램 구현
        //1 + 2 + 3 + 4+ 5 + ......
        int n = 20;
        int sum = 0;     //합

        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;  //1누적식
        }
        Debug.Log($"합은 {sum}");

        //1부터 10까지의 정수중 짝수들의 합을 구하는 프로그램 구현

        // 1. 합계를 담을 '합계 상자'를 만들고 0으로 시작합니다.
        int evenSum = 0;

        // 2. 1부터 10까지 하나씩 확인합니다.
        for (int i = 1; i <= 10; i++)
        {
            // 3. 만약(if) i를 2로 나눈 나머지(%)가 0이라면? (=짝수라면)
            if (i % 2 == 0)
            {
                // 4. 합계 상자에 그 숫자를 더합니다.
                evenSum = evenSum + i;
            }
        }

        // 5. 최종 결과 출력!
        Debug.Log("1부터 10까지 짝수들의 합은: " + evenSum);

        Debug.Log("=============");

        //5부터 1까지 1씩 감소하면서 값을 출력
        for (int i = 5; i >= 1; i--)
        {
            Debug.Log($"countDown: {i}");
        }
        /*
        //무한루프
        //for (; ; )
        {
            //반복 실행문
            Debug.Log("무한루프");
        }*/

            }  
};
    
    

   
