using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnekodlari : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void basla()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
