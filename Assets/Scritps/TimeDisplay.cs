using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText; // �ð��� ǥ���� UI Text

    void Update()
    {
        // ���� �ð��� �ҷ��ͼ� "HH:mm:ss" �������� ǥ��
        timeText.text = DateTime.Now.ToString("HH:mm:ss");
    }
}
