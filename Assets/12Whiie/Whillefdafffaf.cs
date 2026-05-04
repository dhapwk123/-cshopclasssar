using UnityEngine;

//1부터 100까지의 정수중에 3의 배수 또는 4의 배수를 구해서 합하는 프로그램을 구현
public class Whillefdafffaf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*{
            // 1. 합계를 담을 상자를 준비합니다.
            int totalSum = 0;

            // 2. 1부터 100까지 하나씩 확인합니다.
            for (int i = 1; i <= 100; i++)
            {
                // 3. 조건: 3의 배수(i % 3 == 0) '또는(||)' 4의 배수(i % 4 == 0)
                // '||' 기호는 키보드 Enter키 위의 역슬래시(\)를 Shift 누르고 치면 나옵니다!
                if (i % 3 == 0 || i % 4 == 0)
                {
                    totalSum += i; // 조건을 만족하면 합계에 더하기
                }
            }

            // 4. 결과 출력 (디버그 로그)
            Debug.Log($"1부터 100까지 3의 배수 또는 4의 배수의 합은: {totalSum}입니다.");
        }*/

        // 1. 합계를 저장할 상자(변수)를 만듭니다.
        int totalSum = 0;

        // 2. for문을 사용하여 1부터 100까지 반복합니다.
        // (시작: 1, 조건: 100까지, 변화: 1씩 증가)
        for (int i = 1; i <= 100; i++)
        {
            // 3. 만약 i가 3의 배수이거나 또는 4의 배수라면?
            // %는 나머지를 구하는 기호, ||는 '또는(OR)'을 뜻하는 기호입니다.
            if (i % 3 == 0 || i % 4 == 0)
            {
                // 4. 조건에 맞는 숫자 i를 totalSum에 더해줍니다.
                totalSum = totalSum + i;

                // [선택사항] 어떤 숫자가 더해지는지 궁금하면 아래 로그를 켜보세요.
                // Debug.Log("더해지는 숫자: " + i);
            }
        }

        // 5. 최종 결과 출력!
        Debug.Log("1부터 100까지 3의 배수 또는 4의 배수의 합은: " + totalSum);
    }
}

    // Update is called once per frame
    
