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

    // rigid body���� �浹 = collision

    // trigger�� �����ϸ� AI������ ��� ����
    private void OnTriggerEnter(Collider other)
    {
        // [�÷��̾� �ｺ���� �ݶ��̴� ó�� �� ��]
        // other.tag =="bullet";
        // Bullet bullet = other.GetComponent<bullet(); // �±׸� �̿��ص� �ǰ�, getComponent�� �̿� �� �� ������
        // if (null == other.GetComponent<Bullet>()) // ���� other�� bullet�̶�� ������Ʈ�� ������ ������..
        if (other.tag == "Bullet")
        {
            Die();
            Debug.Log("�ڡڡ��÷��̾ ����Ͽ����ϴ١ڡڡ�");
            playerDie = true;
        }

        // [�ҷ��� �ݶ��̴� ó���� ��]

        // ? ������
        // (expression)? : expression�� null�� �ƴϸ� ����� ������.


        //if (playerHealth != null)
        //{
        //    playerHealth.Die();
        //}


        // 1��° ���. (���� ��ȣ���)
        // PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        // playerHealth?.Die();


        // 2��° ���.
        // other.GetComponent<PlayerHealth>?.Die();


        // 3��° ���.
        //if (other.tag == "Player")
        //{
        //    other.GetComponent<PlayerHealth>().Die();
        //}


    }
}
