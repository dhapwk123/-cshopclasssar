using UnityEngine;

public class whiiiesum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //while문을 이용해서 1부터 100까지의 합을 구하는 프로그램을 구현
        
        {
            int number = 1;
            int sum = 0;

            while (number <= 100)
            {
                sum += number;
                number++;
            }

            // 여기에 디버그 로그를 입력합니다!
            Debug.Log($"[계산 완료] 1부터 100까지의 합은 {sum}입니다.");
        }
    }
}

    // Update is called once per frame
    
