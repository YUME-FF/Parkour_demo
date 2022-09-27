using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToGameN : MonoBehaviour
{
    void Start()
    {
        //System.Threading.Thread.Sleep(1000);
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SceneManager.LoadSceneAsync("2Scene");//切换到的场景
    }
    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {

    }
}
