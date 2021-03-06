﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HpDamageManager : MonoBehaviour
{
    private Image hpBar;
    private Text hpText;

    private void Start()
    {
        hpBar = transform.GetChild(1).GetComponent<Image>();
    }

    private void Update()
    {
        FixedAngle();
    }

    /// <summary>
    /// 固定角度：不要讓血條旋轉
    /// </summary>
    private void FixedAngle()
    {
        // 變形.歐拉角度(世界角度) = 三維向量(x, y, z)
        transform.eulerAngles = new Vector3(35, -180, 0);
    }

    /// <summary>
    /// 更新血條
    /// </summary>
    /// <param name="hpCurrent">目前血量</param>
    /// <param name="hpMax">最大血量</param>
    public void UpdateHpBar(float hpCurrent, float hpMax)
    {
        hpBar.fillAmount = hpCurrent / hpMax;
    }
}
