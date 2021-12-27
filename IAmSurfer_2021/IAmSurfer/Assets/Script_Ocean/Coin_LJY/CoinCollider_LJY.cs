﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollider_LJY : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UnityEngine.Debug.Log("코인 획득!");
            PlayerController.Instance.playerData.money++;
            UnityEngine.Debug.Log("지금 현재 코인: " + PlayerController.Instance.playerData.money);
            gameObject.SetActive(false);
        }
    }
}
