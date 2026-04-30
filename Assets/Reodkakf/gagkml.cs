using UnityEngine;
using UnityEngine.Rendering;

public class gagkml : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool isR = false;

      isR = (i ==  3) && (j != 3); //i가 3과 같고, j가 5와 같은가? true
        Debug.Log($"isR: {isR}"); //true

        isR = (i  !=isR)




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
