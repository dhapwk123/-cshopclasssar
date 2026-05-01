using UnityEngine;

public class gagkml : MonoBehaviour
{
    void Start()
    {
        int i = 3;
        int j = 5;
        bool isR = false;

        // [1] 논리곱(&&) 연산: 둘 다 참이어야 참!
        // i가 3이고, j가 3이 아니므로 true && true => true
        isR = (i == 3) && (j != 3);
        Debug.Log($"isR (AND 연산 결과): {isR}");

        // [2] 수정된 비교문: 숫자는 숫자끼리!
        // i(3)가 3이 아닌가? 아니요, 3이죠? 그래서 false가 나옵니다.
        isR = (i != 3);
        Debug.Log($"isR (비교 연산 결과): {isR}");

    } // Start 함수 끝

    void Update()
    {
    }
} // 클래스 끝
