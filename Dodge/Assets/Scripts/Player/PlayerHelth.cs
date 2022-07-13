using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelth : MonoBehaviour
{
    public bool playerDie;

    void Start()
    {
        playerDie = false;
    }

    public void Die()
    {
        gameObject.SetActive(false);

        //FindObjectOfType<GameManager>().End(); 

    }

    // rigid body끼리 충돌 = collision

    // trigger를 응용하면 AI에서도 사용 가능
    private void OnTriggerEnter(Collider other)
    {
        // [플레이어 헬스에서 콜라이더 처리 할 떄]
        // other.tag =="bullet";
        // Bullet bullet = other.GetComponent<bullet(); // 태그를 이용해도 되고, getComponent를 이용 할 수 도있음
        // if (null == other.GetComponent<Bullet>()) // 만약 other가 bullet이라는 컴포넌트를 가지고 있으면..
        if (other.tag == "Bullet")
        {
            Die();
            Debug.Log("★★★플레이어가 사망하였습니다★★★");
            playerDie = true;
        }

        // [불렛에 콜라이더 처리할 때]

        // ? 연산자
        // (expression)? : expression이 null이 아니면 멤버에 접근함.


        //if (playerHealth != null)
        //{
        //    playerHealth.Die();
        //}


        // 1번째 방식. (가장 선호방식)
        // PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        // playerHealth?.Die();


        // 2번째 방식.
        // other.GetComponent<PlayerHealth>?.Die();


        // 3번째 방식.
        //if (other.tag == "Player")
        //{
        //    other.GetComponent<PlayerHealth>().Die();
        //}


    }
}
