using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BackmusicD : MonoBehaviour
{
  
    public AudioClip music1, music2, music3, music4, music5, music6, music7, music8, music9, music10, music11, music12, music13, music14, music15, music16;
    private AudioSource back;
    public Slider slider;
    private int day;
    private int hour;
    // Start is called before the first frame update
    void Start()
    {
        hour = DateTime.Now.Hour;
        day = DateTime.Now.Day;
        back = this.GetComponent<AudioSource>();
        back.loop = true; //设置循环播放  
        back.volume = 0.5f;//设置音量最大，区间在0-1之间
        //back.clip = music;
        //back.Play(); //播放背景音乐；
        if (day > 15)
            if (hour >= 8 && hour < 10)
            {
                back.clip = music1;
                back.Play(); 
            }
            else if (hour >= 10 && hour < 12)
            {
                back.clip = music2;
                back.Play();
            }
            else if (hour >= 12 && hour < 14)
            {
                back.clip = music3;
                back.Play();
            }
            else if (hour >= 14 && hour < 15)
            {
                back.clip = music4;
                back.Play();
            }
            else if (hour >= 15 && hour < 16)
            {
                back.clip = music5;
                back.Play();
            }
            else if (hour >= 16 && hour < 17)
            {
                back.clip = music6;
                back.Play();
            }
            else if (hour >= 17 && hour < 18)
            {
                back.clip = music7;
                back.Play();
            }
            else if (hour >= 18 && hour < 19)
            {
                back.clip = music8;
                back.Play();
            }
            else if (hour >= 19 && hour < 20)
            {
                back.clip = music9;
                back.Play();
            }
            else if (hour >= 20 && hour < 21)
            {
                back.clip = music10;
                back.Play();
            }
            else if (hour >= 21 && hour < 23)
            {
                back.clip = music11;
                back.Play();
            }
            else
            {
                back.clip = music2;
                back.Play();
            }
        else if (day <= 15)
            if (hour >= 8 && hour < 10)
            {
                back.clip = music1;
                back.Play();
            }
            else if (hour >= 10 && hour < 12)
            {
                back.clip = music10;
                back.Play();
            }
            else if (hour >= 12 && hour < 14)
            {
                back.clip = music12;
                back.Play();
            }
            else if (hour >= 14 && hour < 15)
            {
                back.clip = music7;
                back.Play();
            }
            else if (hour >= 15 && hour < 16)
            {
                back.clip = music10;
                back.Play();
            }
            else if (hour >= 16 && hour < 17)
            {
                back.clip = music13;
                back.Play();
            }
            else if (hour >= 17 && hour < 18)
            {
                back.clip = music14;
                back.Play();
            }
            else if (hour >= 18 && hour < 19)
            {
                back.clip = music15;
                back.Play();
            }
            else if (hour >= 19 && hour < 20)
            {
                back.clip = music16;
                back.Play();
            }
            else if (hour >= 20 && hour < 21)
            {   
                back.clip = music8;
                back.Play();
            }
            else if (hour >= 21 && hour < 23)
            {
                back.clip = music14;
                back.Play();
            }
            else
            {
                back.clip = music11;
                back.Play();
            }
    }

    // Update is called once per frame
    void Update()
    {
        back.volume = slider.value;
    }
}
