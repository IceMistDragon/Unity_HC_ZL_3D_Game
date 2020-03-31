﻿using UnityEngine;

public class LeamField : MonoBehaviour
{

    public int speed = 10;
    public float jump = 50.5f;
    public string prop = "小刀";
    public bool complete = true;

    // Header 標題
    // Tooltip 提示
    // Range 範圍 : int、float
    [Header("武器"), Tooltip("這是角色的主要武器。")]
    public string weapon = "BB槍";
    [Header("分數"), Range(0, 100)]
    public int score = 60;

}
