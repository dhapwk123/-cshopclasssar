using UnityEngine;

public class Whille : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 1씩 증가하면서 값을 출력 -5번 반복
        //
        int i = 5; //[1] 초기식

        while (i <= 5) ;   //[2]조건식
        {
            //반복 실행문
            Debug.Log($"count:   {i}");

        }



        //5부터 1까지 1씩 감소하면서 값을 출력

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
