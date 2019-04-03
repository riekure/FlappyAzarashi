﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzarashiController : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float maxHeight;
    public float flapVelocity;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 最高速度に達していない場合に限り、タップ入力を受け入れる
        if (Input.GetButtonDown("Fire1") && transform.position.y < maxHeight)
        {
            Flap();
        }
    }

    public void Flap()
    {
        // Velocityを直接置き換えて上方向に加速
        rb2d.velocity = new Vector2(0.0f, flapVelocity);
    }
}