using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GTime : MonoBehaviour
{
    private Text CurrentTimeText;
    private int hour;
    private int minute;
    private int year;
    private int month;
    private int day;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTimeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hour = DateTime.Now.Hour;
        minute = DateTime.Now.Minute;
        year = DateTime.Now.Year;
        day = DateTime.Now.Day;
        month = DateTime.Now.Month;

        CurrentTimeText.text = string.Format("{0:D4}/{1:D2}/{2:D2} " + "{3:D2}:{4:D2}", year, month, day, hour, minute);
    }
}
