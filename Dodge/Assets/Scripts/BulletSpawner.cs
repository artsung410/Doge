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
            
            // Instantiate : �������� �����ϴ� �Լ�.
            GameObject bullet = Instantiate(BulletPrefab, transform);

            // LookAt : �÷��̾ ���ϵ��� �����ϴ� �Լ�.
            bullet.transform.LookAt(Player);

            randomElapsedTime = Random.Range(0.5f, 3.5f);
            Debug.Log(randomElapsedTime);
        }

        // Timesclae�� �̿��ϸ� ���Ӽ����� ������ �� ����.
        //Debug.Log(Time.deltaTime);
        // 0.5�� �������� Debug.Log()�� ����.
        // Unity Engine���� �ð��� ���õ� ����� Time�� �ִ�.
    }
}
