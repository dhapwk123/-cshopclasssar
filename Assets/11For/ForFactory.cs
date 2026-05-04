using System;
using UnityEngine;

public class ForFactory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4!값을 구하는 프로그램을 구현
        //4! 값은 ?
        // 1. 결과값을 담을 상자 (곱하기니까 1로 시작!)
        int factorial = 1;

        // 2. 1부터 4까지 반복하며 곱하기
        for (int i = 1; i <= 4; i++)
        {
            factorial = factorial * i;

            // [추천] 과정이 궁금하다면 중간 로그를 찍어볼 수 있어요!
            // Debug.Log(i + "를 곱했을 때 현재 값: " + factorial);
        }

        // 3. 최종 결과 출력 (이 부분이 핵심!)
        // 변수 이름이 factorial이므로 정확하게 써줘야 합니다.
        Debug.Log("4!의 최종 결과값은 : " + factorial);
    }
}


    /*
     factorial
   1i = 1
   2i = 1*2
   3i = 1 * 2 * 3
   4i = 1 * 2 * 3 * 4

    ni = 1 + 2 + 3 + "....."(n-1) = a
    */