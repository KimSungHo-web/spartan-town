using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText; // 시간을 표시할 UI Text

    void Update()
    {
        // 현재 시간을 불러와서 "HH:mm:ss" 형식으로 표시
        timeText.text = DateTime.Now.ToString("HH:mm:ss");
    }
}
