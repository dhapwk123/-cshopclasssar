using UnityEngine;

//bool : 불형. 논리 자료형, 참(true) 또는 거짓(false) 값을 저장
public class boolmono : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool형 변수 선언하고 초기화   
        bool bin = true; //참
        Debug.Log("bin;  " + bin);


        bool isdut = false; //거짓
        Debug.Log("isdut;  " + isdut);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
