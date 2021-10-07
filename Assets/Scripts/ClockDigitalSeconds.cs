﻿using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using System;

public class ClockDigitalSeconds : MonoBehaviour
{
    private Text textClock;

    void Start()
    {
        textClock = GetComponent<Text>();
    }

    void Update()
    {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);

        textClock.text = second;
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}