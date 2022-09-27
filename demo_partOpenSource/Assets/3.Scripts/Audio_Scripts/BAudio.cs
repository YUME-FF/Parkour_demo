using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BAudio : MonoBehaviour
{
    public AudioClip music;
    private AudioSource back;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        back = this.GetComponent<AudioSource>();
        back.volume = 0.5f;//设置音量最大，区间在0-1之间
        back.clip = music;
    }

    // Update is called once per frame
    void Update()
    {
        back.volume = slider.value;
    }
}
