using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class karakter : MonoBehaviour
{
    public GameObject yenidenbaslabutton;

    bool sag=false, sol=false;
    
    void Start()
    {
        yenidenbaslabutton.SetActive(false);
    }

    
    void Update()
    {
        this.transform.Translate(Vector3.forward*12*Time.deltaTime);
        if (sag==true)
        {
            this.transform.Translate(Vector3.left * 10 * Time.deltaTime);
        }
        if (sol==true)
        {
            this.transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
    }

    public void karaktersagdown()
    {
        sag = true;
        sol = false;
    }

    public void karaktersoldown()
    {
        sol = true;
        sag = false;
    }

    public void karaktersagup()
    {
        sag = false;
    }

    public void karaktersolup()
    {
        sol = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("engel"))
        {
            yenidenbaslabutton.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag.Equals("bitis"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("kaybetme");
        }
    }
    public void yenidenbasla()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void baslangic()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
