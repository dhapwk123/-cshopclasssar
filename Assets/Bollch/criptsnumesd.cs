using UnityEngine;

//정수형 변수의 값을 1씩 증가하기
public class criptsnumesd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 변수 num 선언하고 10으로 초기화
        int num = 10;
        //정수형 변수 num의 값을 1씩 증가하는 식 증가해서 다시 num에 저장하기
        num = num + 1;  //num   1 증가식
        Debug.Log($"num의 값: {num}");        //num의 값: 11

        //정수형 변수 num 선언하고 10으로 초기화
        int number = 10;
        //정수형 변수 num의 값을 1씩 감소하는 식 감소해서 다시 num에 저장하기
        number = number - 1;  //number   1 감소식
        Debug.Log($"number의 값: {number}");        //number의 값: 9


        //[3]증가식, 감소식 축약해서 사용하기
        //2씩 증가하는 식
        int x = 3;
        x = x + 2;   //2씩 증가시켜주는 증가식
        Debug.Log($"x: {x}");        //11


        //2씩 증가하는 축약식
        int y = 3;
        y = y + 2;
        y += 2;   //축약 식
        Debug.Log($"y: {y}");  

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
