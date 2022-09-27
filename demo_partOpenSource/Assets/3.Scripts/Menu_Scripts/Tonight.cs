using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tonight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(onclick);
    }

   void onclick()
    {
        SceneManager.LoadSceneAsync("demo night");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
