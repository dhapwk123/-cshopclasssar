using UnityEngine;

public class IfConverter : MonoBehaviour
{
    // 유니티 인스펙터 창에서 조절할 수 있도록 public으로 두거나 [SerializeField]를 써요.
    public int answer = 0;

    void Start()
    {
        // 1. 만약(if) answer가 1과 같다면?
        if (answer == 1)
        {
            Debug.Log("1번 답을 선택했습니다.");
        }
        // 2. 그게 아니고 만약(else if) answer가 2와 같다면?
        else if (answer == 2)
        {
            Debug.Log("2번 답을 선택했습니다.");
        }
        // 3. 그게 아니고 만약(else if) answer가 3과 같다면?
        else if (answer == 3)
        {
            Debug.Log("3번 답을 선택했습니다.");
        }
        // 4. 그게 아니고 만약(else if) answer가 4와 같다면?
        else if (answer == 4)
        {
            Debug.Log("4번 답을 선택했습니다.");
        }
        // 5. 위의 모든 조건에 해당하지 않는 '나머지(else)' 경우라면?
        else
        {
            Debug.Log("잘못 선택하셨습니다.");
        }
    }
}