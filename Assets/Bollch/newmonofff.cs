using UnityEngine;

//증가 연산자(++) : 변수의 값을 1씩 증가한다
//감소 연산자(--) : 변수의 값을 1씩 감소한다
public class newmonofff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 증가 연산자
        int num = 100;


        //1씩 증가
        //num = num + 1;          //101
        //num += 1;               //101
        ++num;                    //101


        Debug.Log($"num의 값: {num}");        //num의 값: 101



        //[2] 감소 연산자
         int number = 100;

        //1씩 감소  
        number = number - 1;      //99  

        Debug.Log($"number의 값: {number}");        //number의 값: 99   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
