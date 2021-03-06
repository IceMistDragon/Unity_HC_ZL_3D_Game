﻿using UnityEngine;

[CreateAssetMenu(fileName = "怪物資料", menuName = "KID/怪物資料")]
public class MonsterData : ScriptableObject
{
    [Header("血量"), Range(100, 10000)]
    public float hp;
    [Header("攻擊"), Range(10, 10000)]
    public float attack;
    [Header("移動速度"), Range(1, 10000)]
    public float speed;
    [Header("補血藥水掉落機率"), Range(0, 1)]
    public float propHP;
    [Header("加速藥水掉落機率"), Range(0, 1)]
    public float propCD;
    [Header("攻擊冷卻"), Range(1, 10)]
    public float cd;
    [Header("子彈速度"), Range(1, 50)]
    public float bulletSpeedX ;
    public float bulletSpeedZ ;

}
