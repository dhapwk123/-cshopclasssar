using UnityEngine;

//operations: 연산자.+-*/%
public class oper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Unary operator: (단항 연산0자) +,-,++,--
        int value = 0; //정수형 변수 value 선언과 동시에 0으로 초기화

        value = 0;     //정수형 변수 value에 0 저장
        value = +value; //정수형 변수 value에 +value값을 저장한다
        Debug.Log(value);     //    ?value값을 콘솔창에 출력한다

        value = -8; //정수형 변수 value에 -8 저장
        value = +value; //정수형 변수 value에 +value값을 저장한다
        Debug.Log(value);      //?value값을 콘솔창에 출력한다     

        value = -8;   //정수형 변수 value에 8을 저장
        value = -value;  //정수형 변수 value에 - value값을 저장한다
        Debug.Log(value);      //?value값을 콘솔창에 출력한다

        value = -8;     //정수형 변수 value에 -8 저장
        value = -value; //정수형 변수 value에 -value값을 저장한다
        Debug.Log(value);      //?value값을 콘솔창에 출력한다

        //[2](이항)연산자: +,-,*,/,%(나머지 연산)
        int i = 5;
        int j = 3;

        int k;


        k = i + j;
        Debug.Log(k);
        k = i - j;
        Debug.Log(k);
        k = i * j;
        Debug.Log(k);
        k = i / j;
                Debug.Log(k);
        k = i % j;
        Debug.Log(k);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
