using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // ������Ƽ�� bool Ÿ���� Up, Down, Left, Right �����

    public float X { get; private set; }
    public float Y { get; private set; }

    // Update is called once per frame
    void Update()
    {
        // ���� ���� ������, �⺻ ������ �ʱ�ȭ
        X = Y = 0f;

        // ���� �������� �Է� ���� ����
        X = Input.GetAxis("Horizontal"); // ~1 ~ 1
        Y = Input.GetAxis("Vertical"); // -1 ~ 1
    }
}
