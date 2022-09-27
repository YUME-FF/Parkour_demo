using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class LoadScene : MonoBehaviour
{
    public Text loadingText;
    public Image progressBar;
    private int curProgressValue = 0;
    private int hour;

    private void FixedUpdate()
    {
        CheckTurn.turn = 0;
        int progressValue = 100;
        hour = DateTime.Now.Hour;
        if(curProgressValue < progressValue)
        {
            curProgressValue++;
        }

        loadingText.text = "我们正在全力加载中哦……" + curProgressValue + "%";//更新进度百分比

        progressBar.fillAmount = curProgressValue / 100f;//更新滑动进度图片的fillAmount值；

        if (curProgressValue == 100)
        {
            loadingText.text = "准备就绪，游戏即将开始！";
            if(hour < 18 && hour > 8)
                SceneManager.LoadSceneAsync("Demo Day");
            else
                SceneManager.LoadSceneAsync("Demo Night");
        }
    }
    // Start is called before the first frame update
}
