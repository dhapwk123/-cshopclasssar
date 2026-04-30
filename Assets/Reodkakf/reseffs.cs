using UnityEngine;

//Relational operator(관계 연산자, 비교 연산자) : 두 피연산자의 관계를 비교하여 참(true) 또는 거짓(false)을 반환하는 연산자
//  <(작음)  , >(큼), <=(작거나 같음), >=(크거나 같음), ==(같음), !=(같지 않음)
// 연산 결과 : 참(true) 또는 거짓(false)
public class reseffs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3;
        int b = 5;


        Debug.Log(a < b);     //a가 b보다 작은가? true
        Debug.Log(a <= b);    //a가 b보다 작거나 같은가? true
        Debug.Log(a > b);     //a가 b보다 큰가? false
        Debug.Log(a  >= b);   //a가 b보다 크거나 같은가? false
        Debug.Log(a == b);    //a가 b와 같은가? false
        Debug.Log(a != b);    //a가 b와 같지 않은가? true

        Debug.Log("AAA"  == "aaa");  //문자열 비교: false 대문자와 소문자는 다르다


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
