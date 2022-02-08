using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{

    Rigidbody2D rb;

    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 0은 마우스 좌클릭 or 스마트폰 터치
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,1)
        }
    }

    // 트리거와는 다르게 Collision은 Collider끼리 충돌을 판단
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Scene 이 (참고로 Scene을 추가할때는 Unity->파일->Build Setting 에서 Scene추가 해줘야함)
        SceneManager.LoadScene("GameOverScene");
    }
}
