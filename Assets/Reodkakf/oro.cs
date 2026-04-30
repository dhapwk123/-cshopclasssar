using UnityEngine;

// orOperator(or연산자, ||) : 둘 중 하나라도 참이면 참
// 결과 : 참(true) 또는 거짓(false)
// 불형이 두개 합쳐서 연산일떄 하나라도 참이면 참, 둘 다 거짓이면 거짓
public class oro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //[1] 둘 다 참인 경우
        Debug.Log(true || true); //true

        //[2] 하나라도 참인 경우
        Debug.Log(false || true); //true
        Debug.Log(true || false); //true

        //[3] 둘 다 거짓인 경우
        Debug.Log(false || false); //false


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
