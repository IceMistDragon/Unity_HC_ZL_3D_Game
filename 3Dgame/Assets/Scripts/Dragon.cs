﻿using UnityEngine;
using System.Collections;

public class Dragon : MonoBehaviour
{
    [Header("移動速度"), Range(1, 1000)]
    public float speed = 300;
    [Header("虛擬搖桿")]
    public Joystick joy;
    [Header("攻擊冷卻時間")]
    public float cd = 1;
    [Header("延遲生成火球時間")]
    public float delayFire = 0.5f;
    [Header("火球")]
    public GameObject fireBall;
    [Header("火球移動速度"), Range(1, 1000)]
    public float speedFireBall = 300;

    /// <summary>
    /// 動畫控制器
    /// </summary>
    private Animator ani;
    /// <summary>
    /// 計時器
    /// </summary>
    private float time;

    /// <summary>
    /// 移動
    /// </summary>
    public void Move()
    {
        print("移動中~");

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate(speed * Time.deltaTime * h, 0, speed * Time.deltaTime * v);

        float joyV = joy.Vertical;
        float joyH = joy.Horizontal;

        transform.Translate(speed * Time.deltaTime * joyH, 0, speed * Time.deltaTime * joyV);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, 17, 80);
        pos.z = Mathf.Clamp(pos.z, 1, 20);

        transform.position = pos;
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
        time += Time.deltaTime;
        //print("計時器:" + time);
        if (time >= cd)
        {
            time = 0;
            ani.SetTrigger("攻擊觸發");

            StartCoroutine(DelayFireBall());
        }
    }

    /// <summary>
    /// 延遲火球
    /// </summary>
    /// <returns></returns>
    private IEnumerator DelayFireBall()
    {
        yield return new WaitForSeconds(delayFire);           //生成火球

        Vector3 posFire = transform.position;                 //火球座標 = 飛龍座標
        posFire.z += 1.8f;
        posFire.y -= 0f;

        GameObject temp = Instantiate(fireBall, posFire, Quaternion.identity); //生成(物件 座標 角度)

        temp.GetComponent<Rigidbody>().AddForce(0, 0, );
    }

    private void Start()
    {
        // 取得元件<泛型>()
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        Attack();
    }
}
