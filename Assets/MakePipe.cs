using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{

    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 만약 6프레임 성능의 디바이스라면 deltaTime 은 1/6
        timer += Time.deltaTime;
        // 1초마다 생성해준다.
        if (timer > timeDiff) {
            // Object 생성
            GameObject pipeClone = Instantiate(pipe);
            pipeClone.transform.position = new Vector3(3, Random.Range(-1,4), 0);
            timer = 0;
            // 10초뒤 destroy
            Destroy(pipeClone, 10);
        }
    }
}
