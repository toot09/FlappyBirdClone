using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime 은 성능에 따라 프레임수가 다를때 맞춰 줄 수 있는 값
        transform.position += Vector3.left * Time.deltaTime * speed; //(-1, 0, 0)
    }
}
