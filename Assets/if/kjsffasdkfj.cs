using UnityEngine;

//점수가 60점이상이면 합격을 출력, 아니면 불합격을 출력
public class kjsffasdkfj : MonoBehaviour
{
    //점수 입력
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(score >= 60) //점수가 60점이상이면
        {
            //실행은: 합격출력
            Debug.Log("합격");
        }
        else
        {
            //실행은: 불합격출력
            Debug.Log("불합격");
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
