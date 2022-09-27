using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class BackM : MonoBehaviour
{
    //显示进度的文本
    public Text progress;
    //进度条的数值
    private float progressValue;
    //进度条
    public Slider slider;
    [Tooltip("下个场景的名字")]
    //public string nextSceneName;
    private int hour;

    private AsyncOperation async = null;

    private void Start()
    {
        progress = GetComponent<Text>();
        slider = FindObjectOfType<Slider>();
        StartCoroutine("LoadScene");
    }

    IEnumerator LoadScene()
    {
        hour = DateTime.Now.Hour;
        if (hour < 18 && hour > 8)
            async = SceneManager.LoadSceneAsync("Demo Day");
        else
            async = SceneManager.LoadSceneAsync("Demo Night");
        async.allowSceneActivation = false;
        while (!async.isDone)
        {
            if (async.progress < 0.9f)
                progressValue = async.progress;
            else
                progressValue = 1.0f;

            slider.value = progressValue;
            progress.text = (int)(slider.value * 100) + " %";

            if (progressValue >= 0.9)
            {
                progress.text = "按任意键继续";
                if (Input.anyKeyDown)
                {
                    async.allowSceneActivation = true;
                }
            }

            yield return null;
        }

    }
}
