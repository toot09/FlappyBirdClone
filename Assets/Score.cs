using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    // static 형으로 Score 클래스 외의 클래스에서 참조할 수 있음
    public static int score;
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}
