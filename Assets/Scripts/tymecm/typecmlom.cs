using UnityEngine;

//형식 변환 실습
public class typecmlom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //double형 변수 d를 선언하고 12.34 초기화    
        double d = 12.34; //실수형 64bit
        //int 형 변수 i 선언하고 1234 초기화
        int i = 1234;

        //[1] d에 있는 값을 i에 저장하기 (double -> int, 명시적 변환 필요)
        i = (int)d;
        Debug.Log($"명시적 형식변환: {i}");

        //값 복원
        d = 12.34;
        i = 1234;
       


        //[2] i에 있는 값을 d에 저장하기 (int -> double, 암묵적 변환 가능)
        i = (int)d; //(캐스트 연산자) 
        Debug.Log($"암묵적 형식변환: {d}");


        d = 12.34;
        i = 1234;

        //[3] 숫자가 아닌 다른 형식간의 변화
        //문자열 변수 선언하고 초기화
        string s = "";   //빈 문자열로 초기화
                         //s에 d값 저장하기, d값을 문자열로 변환해서 저장하기
        s = d.ToString(); //ToString() 메서드 : 숫자 -> 문자열로 변환하는 메서드
        Debug.Log ($"d를 문자열로 변환해서 s에 저장하기: {s}");
    }
}