using UnityEngine;

// NotOperator(not 연산자, !) : 참이면 거짓이되고, 거짓이면 참이 되는 연산자
// 결과 : 참(true) 또는 거짓(false)
public class not : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(!true); //false  
        Debug.Log(!false); //true

        bool isout = false;

        Debug.Log(!isout); //true isout이 false이므로 !isout은 true가 된다
        Debug.Log(!!isout); //false isout이 false이므로 !!isout은 false가 된다
        Debug.Log(!isout); //true isout이 false이므로 !isout은 true가 된다

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
