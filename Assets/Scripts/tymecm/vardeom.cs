using UnityEngine;

//var : 임시적으로 형식화된 로컬 변수
public class vardeom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string 타입의  name변수 선언하고 홍길동으로 초기화
        var name = "홍길동";   //초기화된 홍길동 값을 보고 컴파일러가 name변수의 타입을 string으로 추론하여 name변수를 string 타입으로 선언
        Debug.Log(name);
        Debug.Log(name.GetType()); //name변수의 타입을 출력

        //double 타입의 version변수 선언하고 8.0으로 초기화
        var version = 8.0;   //초기화된 8.0 값을 보고 컴파일러가 version변수의 타입을 double로 추론하여 version변수를 double 타입으로 선언
        Debug.Log(version);
        Debug.Log(version.GetType()); //version변수의 타입을 출력


        var car = 100;   //초기화된 100 값을 보고 컴파일러가 car변수의 타입을 int로 추론하여 car변수를 int 타입으로 선언
        Debug.Log(car);
        Debug.Log(car.GetType()); //car변수의 타입을 출력

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
