using UnityEngine;

public class Swggg : MonoBehaviour
{
    // 유니티 인스펙터 창에서 숫자를 조절할 수 있게 바꿨어요!
    [Range(1, 5)] // 1부터 5까지만 입력하게 제한하는 센스!
    public int answer = 1;

    void Start()
    {
        //answer 데이터 값 판별
        switch (answer)
        {
            case 1:
                Debug.Log("1번 답을 선택했습니다.");
                break; // 이 문장을 수행했으면 switch문을 나갑니다.

            case 2:
                Debug.Log("2번 답을 선택했습니다.");
                break;

            case 3:
                Debug.Log("3번 답을 선택했습니다.");
                break;

            case 4:
                Debug.Log("4번 답을 선택했습니다.");
                break;

            default:
                // 1, 2, 3, 4가 아닌 모든 경우(예: 5, 0, -1 등)
                Debug.Log("잘못 선택하셨습니다.");
                break;
        }
    }
}
