using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 玩家移动
/// </summary>
public class PlayerMove : MonoBehaviour
{
    // 获取玩家刚体
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rb.velocity = new Vector2(3, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _rb.velocity = new Vector2(-3, 0);
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
        else
        {
            _rb.velocity = new Vector2(0, 0);
        }
    }
}