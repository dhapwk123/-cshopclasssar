using UnityEngine;

//prefixoperador(전위 증강연산자)  : 앞에 위치하는 증강연산자, 같은 라인에서 연산하는 순위가 가장 높음
//prefixoperador(후위 증강연산자)  : 뒤에 위치하는 증강연산자. 같은 라인에서 연산하는 순위가 가장 낮음
public class op : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 전위 증강 연산자
        int i = 3;
        int j = ++i;

        Debug.Log($"i의 값: {i}, j의 값: {j}"); // i의 값: 4, j의 값: 4
        Debug.Log($"j의 값: {j}") ; // j의 값: 4

        //[2] 후위 증강 연산자
        int x = 3;
        int y = x++;        
        Debug.Log($"x의 값: {x}, y의 값: {y}"); // x의 값: 4, y의 값: 3
        Debug.Log($"y의 값: {y}"); // y의 값: 3  

        //[3]증가식 감소식




        //2씩 증가하는 축약식
        int y2 = 3;
        //y2 = y2 + 2;
        y2 += 2;     //축약 식
        Debug.Log($"y2: {y2}");  //5

        //[4] 누적식 (+=, -=, *=, /=)
        int a = 3;
        int b = 3;

        a += b; // a = a + b
        Debug.Log($"a: {a}"); // 6

        //b 변수에 a변수의 값을 감산 누적
        //b = b - a;


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
