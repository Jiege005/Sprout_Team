using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyNum : MonoBehaviour
{
    public int DamageAndLife;
    public Text valueText;

    void Start()
    {
        UpdateDisplay(); // 初始化时更新显示
    }

    // 调用此方法来更新显示的数值
    public void SetValue(int newValue)
    {
        DamageAndLife = newValue;
        UpdateDisplay();
    }

    // 更新Text组件的文本内容
    void UpdateDisplay()
    {
        valueText.text = DamageAndLife.ToString();
    }
}
