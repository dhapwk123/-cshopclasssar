using UnityEngine;

   // + 더하기 연산의 추가 기능, 문자열 더하기
public class udfffjs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          Debug.Log("Hello" + "World"); //문자열 "Hello"와 "World"를 더해서 콘솔창에 출력한다
          Debug.Log("HI"  + "" + "Everyone"); //문자열 "HI"와 "Everyone"을 더해서 콘솔창에 출력한다

          Debug.Log("123" + "456"); //문자열 "123"과 "456"을 더해서 콘솔창에 출력한다)   
          Debug.Log("123" + 456); //문자열 "123"과 정수 456을 더해서 콘솔창에 출력한다
          Debug.Log(123 + "456"  +  (789 + 890)); //정수 123과 문자열 "456"을 더해서 콘솔창에 출력한다
          Debug.Log(123 + 456); //정수 123과 정수 456을 더해서 콘솔창에 출력한다

        Debug.Log("123" + true);   //문자열 boolean true를 문자열 "123"과 더해서 콘솔창에 출력한다

        //Debug.Log("123" -456);  //문자열 "123"과 정수 456을 빼서 콘솔창에 출력한다
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
