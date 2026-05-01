using UnityEngine;

//학점을 출력하는 프로그램
//점수가 90점이상이면 a학점 출력, 80점이상이면 b학점 출력 , 70점이상이면 c학점 출력, 60점이상이면 d학점 출력, 나머지는학점 출력

public class el : MonoBehaviour
{
    //스코어 입력
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
          //학점을 출력하는프로그램
          char frade = 'a'; //점수가 90점이상이면 a학점 출력, 80점이상이면 b학점 출력 , 70점이상이면 c학점 출력, 60점이상이면 d학점 출력, 나머지는학점 출력

        if (score >= 90)
          {
              Debug.Log("A학점");
          }
          else if (score >= 80)
          {
              Debug.Log("B학점");
          }
          else if (score >= 70)
          {
              Debug.Log("C학점");
          }
          else if (score >= 60)
          {
              Debug.Log("D학점");
          }
          else
          {
              Debug.Log("F학점");
          }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
