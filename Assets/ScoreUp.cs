using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    // 트리거 중 2D 진입했을때.
    private void OnTriggerEnter2D(Collider2D collision) {
        Score.score++;
    }
}
