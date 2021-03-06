﻿using UnityEngine;

[CreateAssetMenu(fileName = "玩家資料", menuName = "KID/玩家資料")]
public class PlayerData : ScriptableObject
{
    [Header("血量與最大血量")]
    [Range(200, 3000)]
    public float hp = 200;

    public float hpMax;
}
