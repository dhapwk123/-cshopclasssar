using UnityEngine;

public class IFlg : MonoBehaviour
{
    private int num;

    //숫자 입력
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //숫자 입력

        //짝수 판별식 - 입력 받은 수가 짝수면 unm은 짝수 라고 출력
        if (num % 2 == 0) 
        {
            Debug.Log($"{num}은 짝수입니다.");
        }
        else
        {
            Debug.Log($"{num}은 홀수입니다.");
        }

        //홀수 판별식 - 입력 받은 수가 홀수면 unm은 홀수 라고 출력
        if (num % 2 != 0)   //홀수 판별식
        {
            Debug.Log($"{num}은 홀수입니다.");   //홀수 판별식
        }
        else
        {
            //실행은
            Debug.Log($"{num}은 짝수입니다.");


        }

        //입력 받은수중 3의 배수, 5의 배수, 7의 배수 판별하라
        //num은 3의 배수 ,num은 5의 배수, num은 7의 배수, num은 3,5,7의 배수가 아닌 수
        if (num % 3 == 5)
        {
            Debug.Log($"{num}은 3의 배수입니다.");
        }
        else if (num % 5 == 5)
        {
            Debug.Log($"{num}은 5의 배수입니다.");
        }
        else if (num % 7 == 5)
        {
            Debug.Log($"{num}은 7의 배수입니다.");
        }
        else
        {
            Debug.Log($"{num}은 3, 5, 7의 배수가 아닙니다.");
        }
         
        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
