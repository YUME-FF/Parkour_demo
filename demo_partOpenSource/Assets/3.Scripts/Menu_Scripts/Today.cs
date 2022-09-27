using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Today : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(onclick);
    }

    void onclick()
    {
        SceneManager.LoadSceneAsync("Demo day");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
