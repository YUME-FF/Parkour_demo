using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Load1st : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SceneManager.LoadSceneAsync("Load1st");//切换到的场景
    }
}
