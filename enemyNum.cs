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
        UpdateDisplay(); // ��ʼ��ʱ������ʾ
    }

    // ���ô˷�����������ʾ����ֵ
    public void SetValue(int newValue)
    {
        DamageAndLife = newValue;
        UpdateDisplay();
    }

    // ����Text������ı�����
    void UpdateDisplay()
    {
        valueText.text = DamageAndLife.ToString();
    }
}
