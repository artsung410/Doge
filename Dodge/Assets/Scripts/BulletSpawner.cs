using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    public float randomElapsedTime = 0.5f;
    public float _elapsedTime;

    void Start()
    {
        _elapsedTime = 0;
    }
    void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= randomElapsedTime)
        {
            _elapsedTime = 0f;
            
            // Instantiate : 프리팹을 생성하는 함수.
            GameObject bullet = Instantiate(BulletPrefab, transform);

            // LookAt : 플레이어를 향하도록 설정하는 함수.
            bullet.transform.LookAt(Player);

            randomElapsedTime = Random.Range(0.5f, 3.5f);
            Debug.Log(randomElapsedTime);
        }

        // Timesclae을 이용하면 게임세상을 빨리할 수 있음.
        //Debug.Log(Time.deltaTime);
        // 0.5초 간격으로 Debug.Log()를 찍어보기.
        // Unity Engine에서 시간과 관련된 기능은 Time에 있다.
    }
}
