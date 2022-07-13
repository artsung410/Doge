using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // 충돌과 관련된 정보
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"[OnCollisionEnter] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[OnCollisionStay] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"[OnCollisionExit] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }
    
    // 객체에 들어있는 콜라이더의 정보를 받아온다.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"[OnTriggerEnter] Me : {gameObject.name}, Other : {other.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"[OnTriggerStay] Me : {gameObject.name}, Other : {other.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"[OnTriggerExit] Me : {gameObject.name}, Other : {other.name}");
    }
}
